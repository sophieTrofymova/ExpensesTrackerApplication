using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static ExpenseTracker.Storage.ApplicationState;

using System.Text.Json.Serialization;


namespace ExpenseTracker {


    public class Account {
        public Guid ID { get; private set; }  // Unique account ID
        public string Name { get; set; }  // Example: "Bank", "Wallet", "Credit Card"
        public decimal Balance { get; set; }  // Current balance in the account


        /// <summary>
        /// For serializer only
        /// </summary>
        [JsonConstructor]
        public Account(Guid id) {
            ID = id;
        }

        public Account(string name, decimal balance) {
            Name = name;
            Balance = balance;
            ID = Guid.NewGuid();
        }

        private void UpdateBalance(Transaction transaction) {
            if (transaction.Type == TransactionType.Expense)
                Balance -= transaction.Amount;
            else if (transaction.Type == TransactionType.Income)
                Balance += transaction.Amount;
        }
    }
}
