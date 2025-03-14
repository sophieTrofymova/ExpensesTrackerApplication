using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerApplication
{
    public class RecurrenceInfo
    {
        public RecurrenceFrequency Frequency { get; set; }
        public DateTime NextOccurrence { get; set; }
    }
    public enum RecurrenceFrequency
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
}
