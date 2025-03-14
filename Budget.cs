using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerApplication
{
    public class Budget
    {
        public Budget(string category, decimal amountLimit, BudgetPeriod period)
        {
            Category = category;
            AmountLimit = amountLimit;
            Period = period;
        }

        public Budget(string category, decimal amountLimit, BudgetPeriod period, bool notifications)
        {
            Category = category;
            AmountLimit = amountLimit;
            Period = period;
            Notifications = notifications;
        }

        public string Category { get; set; } 
        public decimal AmountLimit { get; set; }
        public BudgetPeriod Period { get; set; }
        public bool Notifications { get; set; }
    }

    public enum BudgetPeriod
    {
        Weekly,
        Monthly,
        Yearly
    }


}
