using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Transactions;

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

        //public List<Transaction> GetTransactionsByAccount(string accountName) {
        //    return Transactions.Where(t => t.SourceAccount == accountName || t.DestinationAccount == accountName).ToList();
        //}
    }
}
