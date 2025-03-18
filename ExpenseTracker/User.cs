using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ExpenseTracker
{
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
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
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

