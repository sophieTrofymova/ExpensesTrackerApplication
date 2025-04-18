

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static ExpenseTracker.Storage.ApplicationState;

namespace ExpenseTracker
{
    public class Budget
    {
        public Guid ID { get; private set; }

        public string Name { get; set; }
        public List<Guid> AccountsIDs { get; set; }
        public CategoryInfo CategoryInfo { get; set; }
        public decimal AmountLimit { get; set; }
        // public BudgetPeriod Period { get; set; }
        public decimal Spent { get; set; }
        public DateTime Month { get; set; }
        public bool Notifications { get; set; }




        /// <summary>
        /// For serializer only
        /// </summary>
        [JsonConstructor]

        public Budget(Guid id)
        {
            ID = id;
        }

        public Budget(string name, CategoryInfo categoryInfo, decimal amountLimit, List<Guid> accountsIDs)
        {

            ID = Guid.NewGuid();
            Name = name;
            CategoryInfo = categoryInfo;
            AmountLimit = amountLimit;
            Spent = 0;
            Month = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            AccountsIDs = accountsIDs;
        }

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