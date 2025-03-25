using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {


    // Recurrence Details
    public class RecurrenceInfo {


        // Repeat every X days/weeks/months, Example: 
        // - every 6 day or every 2 months or every year etc. * NumberOfTimes 
        // - or by the EndDate
        // - or infinite 
        public int Interval { get; set; } // Repeat every X days/weeks/months (must be >= 1)
        public RecurrenceFrequency Frequency { get; set; }
        public RecurrenceTermination TerminationType { get; set; }
        // by starting from Transaction.EffectDate + number of times to repeat
        public int? NumberOfTimes { get; set; } // Null unless TerminationType == Times

        // reccurence end of of effect determined by
        public DateTime? EndDate { get; set; } // Null unless TerminationType == Date
    }

    // Termination Conditions
    public enum RecurrenceTermination { Times, Date, Infinite }


    // Frequency of Recurrence
    public enum RecurrenceFrequency { Daily, Weekly, Monthly, Yearly }
}
