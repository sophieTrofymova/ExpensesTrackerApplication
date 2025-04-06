using Newtonsoft.Json;


namespace ExpenseTracker
{


    public class User
    {

        public Guid ID { get; } = Guid.NewGuid();  // unique user id
        public string Username { get; set; }
        public string Email { get; set; }

        // display name, full name or whatever user wants, "John Doe" for example, for other users to see
        public string DisplayName { get; set; }

        [JsonProperty]
        private string PasswordHash { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Budget> Budgets { get; set; }

        /// <summary>
        /// for serializer only
        /// </summary>
        public User()
        {

        }

        public User(string username, string email, string displayName, string password)
        {
            Username = username;
            PasswordHash = HashPassword(password);
            Email = email;
            DisplayName = displayName;
            Accounts = new List<Account>();
            Budgets = new List<Budget>();
        }


        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
        }

        public bool SetPassword(string oldPassword, string newPassword)
        {

            if (string.IsNullOrEmpty(newPassword))
                return false;


            if (string.IsNullOrEmpty(PasswordHash) || VerifyPassword(oldPassword))
            {
                PasswordHash = HashPassword(newPassword);
                return true;
            }

            return false;
        }

        public bool AddAccount(Account account)
        {

            // TODO: лучше проверки сделать здесь
            // потому что нам нужно убедится что такого аккаунта несуществует
            if (!Accounts.Where(a => a.Name == account.Name).Any())
            {
                Accounts.Add(account);
                return true;
            }
            else
            {
                return false;
            }


        }

        public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
        }

        public void AddBudget(Budget budget)
        {
            Budgets.Add(budget);
        }

        public List<Budget> GetUsersBudget()
        {
            return Budgets;
        }

    }
}
