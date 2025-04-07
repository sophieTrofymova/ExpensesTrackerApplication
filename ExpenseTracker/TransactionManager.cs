using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Transactions;
using WF = System.Windows.Forms;
using System.Globalization;

namespace ExpenseTracker {

    // Store Transactions Separately(Better for Global Access)

    // ✅ Pros:
    //    Easier to query/search across all transactions.
    //    Makes transfer logic simpler (since transfers belong to two accounts).
    // ❌ Cons:
    //    Requires additional logic to link transactions to accounts.
    //    Slower when fetching transactions for a single account.

    public class TransactionManager {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void AddTransaction(Transaction transaction) {
            Transactions.Add(transaction);
        }
       
        public List<Transaction> GetTransactionsForMonth(int month)
        {
            return Transactions.Where(t => t.EffectDate.Month == month).ToList();
        }

        public void DisplayTransactions(ListView listView, string monthName = null)
        {
            if (listView == null)
            {
                MessageBox.Show("The ListView control is not available.");
                return; 
            }

            int monthNumber;
            if (string.IsNullOrEmpty(monthName) ||
                !DateTime.TryParseExact(monthName, "MMMM", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                monthNumber = DateTime.Now.Month;
            }
            else
            {
                monthNumber = parsedDate.Month;
            }

            var transactions = GetTransactionsForMonth(monthNumber); 
            listView.Items.Clear(); 

            foreach (var transaction in transactions)
            {
                var item = new ListViewItem(transaction.EffectDate.ToString("dd MMM yyyy"));
                item.SubItems.Add(transaction.CategoryDescription);
                item.SubItems.Add(transaction.Amount.ToString("C"));
                listView.Items.Add(item); 
            }
        }


        //public List<Transaction> GetTransactionsByAccount(string accountName) {
        //    return Transactions.Where(t => t.SourceAccount == accountName || t.DestinationAccount == accountName).ToList();
        //}
    }
}
