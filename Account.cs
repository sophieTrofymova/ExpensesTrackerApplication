using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerApplication
{
    public class Account
    {
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public Account() { }

        public Account(string number, decimal balance, string currency, List<Transaction> transactions)
        {
            Number = number;
            Balance = balance;
            Currency = currency;
            Transactions = transactions;
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            UpdateBalance(transaction);
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
