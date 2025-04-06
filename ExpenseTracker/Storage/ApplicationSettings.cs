using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Storage {

    public class ApplicationSettings {
        public bool TestMode { get; set; }

        public Theme CurrentTheme { get; set; }

        public ApplicationSettings() {
            
        }

    }
}
