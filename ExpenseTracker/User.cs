
using Newtonsoft.Json;
using System.Transactions;

namespace ExpenseTracker
{

    class UserManager {

        [JsonProperty] 
        private List<User> users { get; set; }
        public User CurrentUser { get; private set; }


        public UserManager()
        {
            
        }

        public bool Login() {
            return false;
        }

        public bool Logout() {
            return false;
        }

        public bool Register() {
            return false;
        }

    }

    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();
        public List<Budget> Budgets { get; set; } = new List<Budget>();

        public User(Guid id, string username, string password, string email, string name, List<Account> accounts, List<Budget> budgets)
        {   
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Name = name;
            Accounts = accounts;
            Budgets = budgets;
        }
        public User(string username, string password, string email, string name)
        {
            Username = username;
            Password = password;
            Email = email;
            Name = name;
        }
        public User() { }
        
        public List<Budget> GetUsersBudget()
        {
            return Budgets;
        }
        public bool AddAccount(Account account)
        {

            // TODO: лучше проверки сделать здесь
            // потому что нам нужно убедится что такого аккаунта несуществует
            if(! Accounts.Where(a => a.Name == account.Name).Any()) {
                Accounts.Add(account);
                return true;
            } else {
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
    }
}

