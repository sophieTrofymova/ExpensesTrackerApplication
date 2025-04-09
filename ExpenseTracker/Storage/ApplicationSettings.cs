using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Storage {

    public class ApplicationSettings {
        public bool TestMode { get; set; }
        public string ThemeName { get; set; } // No more duplicate serialization
        public CurrencyType CurrencyType { get; set; }

        public ApplicationSettings() {

        }

    }
}
