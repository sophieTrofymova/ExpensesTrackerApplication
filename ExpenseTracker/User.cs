using Newtonsoft.Json;


namespace ExpenseTracker
{


    public class User
    {

        public Guid ID { get; } = Guid.NewGuid();  // unique user id

        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime? LastLoginAt { get; set; }


        public string Username { get; set; }
        public string Email { get; set; }

        // display name, full name or whatever user wants, "John Doe" for example, for other users to see
        public string DisplayName { get; set; }

        [JsonProperty]
        private string PasswordHash { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Budget> Budgets { get; set; }
        public List<Transaction> Transactions { get; private set; } = new List<Transaction>();


        /// <summary>
        /// for serializer only
        /// </summary>
        public User()
        {

        }

        public User(string displayName, string username, string email, string password)
        {
            Username = username;
            PasswordHash = HashPassword(password);
            Email = email;
            DisplayName = displayName;
            Accounts = new List<Account>();
            Budgets = new List<Budget>();
            Transactions  = new List<Transaction>();
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
            if (account == null || string.IsNullOrWhiteSpace(account.Name))
                return false;

            string newName = account.Name.Trim().ToLowerInvariant();

            bool alreadyExists = Accounts.Any(a =>
                !string.IsNullOrWhiteSpace(a.Name) &&
                a.Name.Trim().ToLowerInvariant() == newName
            );

            if (!alreadyExists) {
                Accounts.Add(account);
                return true;
            }

            return false;
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


        public override bool Equals(object? obj) {
            return obj is User other && other.ID == this.ID;
        }

        public override int GetHashCode() {
            return ID.GetHashCode();
        }


        public override string ToString() {
            return $"{DisplayName} ({Username})";
        }


    }
}
