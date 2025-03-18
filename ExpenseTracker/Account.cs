using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {


    public class Account
    {
        public int ID { get; set; }  // Unique account ID
        public string Name { get; set; }  // Example: "Bank", "Wallet", "Credit Card"
        public decimal Balance { get; set; }  // Current balance in the account
        public string Currency { get; set; } // Example: "USD", "EUR", "GBP"

        public Account(int iD, string name, decimal balance, string currency) {
            ID = iD;
            Name = name;
            Balance = balance;
            Currency = currency;
        }

        private void UpdateBalance(Transaction transaction)
        {
            if (transaction.Type == TransactionType.Expense)
                Balance -= transaction.Amount;
            else if (transaction.Type == TransactionType.Income)
                Balance += transaction.Amount;
        }
    }
}
