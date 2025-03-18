using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {
    public class Transaction {
        public int ID { get; set; } // Unique Transaction Identifier
        public TransactionType Type { get; set; } // Expense, Income, Transfer

        public decimal Amount { get; set; }
        public string Category { get; set; } // Food, Rent, Salary, etc.

        // The account where the money is coming from
        public string SourceAccount { get; set; } // Example: "Bank", "Wallet", "Credit Card"

        // Only applicable if it's a transfer (null for expenses & income)
        public string? DestinationAccount { get; set; } // Example: "Bank" → "Wallet" transfer

        public DateTime Date { get; set; } // When the transaction occurred
        public string? Description { get; set; }  // Optional(or null) description

        // -----------------------------------------------------------------------------
        public bool Recurring { get; set; }
        public RecurrenceInfo? RecurrenceInfo { get; set; }


        // public TransactionStatus Status { get; set; } // make sense only in case of actual banking app

        public Transaction()
        {
            
        }

    }

    public enum TransactionType {
        Expense,
        Income,
        Transfer
    }

    //public enum TransactionStatus {
    //    Pending,
    //    Completed,
    //    Failed
    //}


}
