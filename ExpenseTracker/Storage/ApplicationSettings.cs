using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Storage {

    public class ApplicationSettings {
        public bool TestMode { get; set; }

        public Theme CurrentTheme { get; set; }
        public CurrencyType CurrencyType { get; set; }

        public ApplicationSettings() {
            CurrencyType = CurrencyType.EUR; //default currency
            TestMode = true; //default test mode
            CurrentTheme = new Theme(); 
        }

    }
}
