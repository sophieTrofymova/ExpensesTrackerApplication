using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerApplication
{
    public class Transaction
    {
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; } 
        public DateTime DateTime { get; set; }  
        public TransactionStatus Status { get; set; }
        public string Description { get; set; } 
        public bool Recurring { get; set; } 
        public RecurrenceInfo RecurrenceInfo { get; set; } 
    }

    public enum TransactionType
    {
        Expense,
        Income,
        Transfer
    }

    public enum TransactionStatus
    {
        Pending,
        Completed,
        Failed
    }


}
