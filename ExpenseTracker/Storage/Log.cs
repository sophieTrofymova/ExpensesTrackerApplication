using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Storage {
    public static class Log {
        private static readonly object logLock = new object();
        private static string logFilePath = "app.log.txt"; // by default

        /// <summary>
        /// Sets the log file path externally.
        /// </summary>
        public static void SetLogFilePath(string path) {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Log file path cannot be empty.", nameof(path));

            logFilePath = path;
        }

        /// <summary>
        /// Logs a message to the log file with a timestamp.
        /// </summary>
        public static void Message(string msg) {
            try {
                lock (logLock) //for thread safe, not my idea obviously 
                {
                    using (var sw = new StreamWriter(logFilePath, append: true, Encoding.UTF8)) {
                        sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {msg}");
                    }
                }
            }
            catch (IOException ex) {
                MessageBox.Show(ex.Message, "Logging Error");
            }
        }
    }
}
