using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {
    public class Budget
    {
        public Budget(Guid accountId, CategoryInfo categoryInfo, decimal amountLimit/*,BudgetPeriod period*/)
        {
            AccountID = accountId;
            CategoryInfo = categoryInfo;
            AmountLimit = amountLimit;
            Spent = 0;
            Month = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //Period = period;
        }

        //public Budget(CategoryType category, decimal amountLimit, /*BudgetPeriod period,*/ bool notifications)
        //{
        //    Category = category;
        //    AmountLimit = amountLimit;
        //   // Period = period;
        //    Notifications = notifications;
        //    Spent = 0;
        //}

        public Guid AccountID { get; set; }
        public CategoryInfo CategoryInfo { get; set; }
        public decimal AmountLimit { get; set; }
        // public BudgetPeriod Period { get; set; }
        public decimal Spent { get; set; }
        public DateTime Month { get; set; }
        public bool Notifications { get; set; }

        public string CategoryDescription => CategoryInfo.Description;
        public decimal GetUsagePercentage()
        {
            return (AmountLimit == 0) ? 0 : (Spent / AmountLimit) * 100;
        }

        public bool NeedsWarning()
        {
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int today = DateTime.Now.Day;

            bool over70Percent = GetUsagePercentage() >= 70;
            bool lessThanHalfMonth = today < (daysInMonth / 2);

            return over70Percent && lessThanHalfMonth;
        }
    }

    public enum BudgetPeriod
    {
        Weekly,
        Monthly,
        Yearly
    }

}

