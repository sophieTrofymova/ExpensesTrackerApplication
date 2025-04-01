using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {

    public enum CurrencyType
    {
        EUR,
        USD,
        GBP
    }
    public class Account
    {
        public Guid ID { get; private set; } = Guid.NewGuid(); // Unique account ID
        public string Name { get; set; }  // Example: "Bank", "Wallet", "Credit Card"
        public decimal Balance { get; set; }  // Current balance in the account
        public CurrencyType Currency { get; set; } // Example: "USD", "EUR", "GBP"

        public Account( string name, decimal balance, CurrencyType currency) {
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
