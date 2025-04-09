using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {

    public enum TransactionType { Expense, Income, Transfer }

    public class Transaction {

        // Unique identifier
        public Guid ID { get; set; } 

        // Metadata for management 
        public DateTime CreationDate { get; private set; } = DateTime.Now;

        // Financial Details
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; } // Must be positive
        // Category: Food, Rent, Salary, etc.
        //public string Category { get; set; }
        public CategoryInfo CategoryInfo { get; set; }

        public string CategoryDescription => CategoryInfo.Description;

        // Accounts Involved


        // income or used in transfer
        public Guid ReceiverAccount { get; set; } // Account that receives funds

        // expense or used transfer
        public Guid SenderAccount { get; set; } // Account that sends funds

        // Transaction Start Date (When it takes effect)
        // date from which effect start/ day of first transaction
        public DateTime EffectDate { get; set; }
        // description can contain \r\n\t to format text
        public string? Description { get; set; }

        // does this transaction repeats
        public bool Recurring { get; set; } = false;
        // repeat settings
        public RecurrenceInfo? RecurrenceInfo { get; set; }

        public Transaction()
        {
            
        }

        public Transaction(Guid creatorAccount) {
            ID = Guid.NewGuid();
            SenderAccount = creatorAccount;
        }
    }




}
