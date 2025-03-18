using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {


    // New class to store recurrence details
    public class RecurrenceInfo {
        public RecurrenceFrequency RecurrenceFrequency { get; set; } // Daily, Weekly, Monthly, Yearly
        public int Interval { get; set; } // Repeat every X days/weeks/months
        public DateTime? EndDate { get; set; } // Null means infinite recurrence
    }


    public enum RecurrenceFrequency
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
}
