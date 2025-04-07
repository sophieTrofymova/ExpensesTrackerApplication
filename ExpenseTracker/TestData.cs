
using Microsoft.VisualBasic.ApplicationServices;

namespace ExpenseTracker
{

    /// <summary>
    /// Test data filler
    /// </summary>
    public static class TestData {

        public static void GenerateTestUsers(UserManager userManager) {
            if (userManager == null)
                throw new ArgumentNullException(nameof(userManager));


            var rnd = new Random();
            var names = new[] { "John", "Alice", "Bob", "Diana", "Eve" };
            var domains = new[] { "mail.com", "test.org", "demo.net" };

            for (int i = 0; i < names.Length; i++) {
                string displayName = $"{names[i]} Test";
                string username = $"{names[i].ToLowerInvariant()}_{i + 1}";
                string email = $"{username}@{domains[i % domains.Length]}";
                string password = "pass123";

                if (userManager.Register(displayName, username, email, password) != ValidationResult.Success)
                    continue;

                var user = userManager.GetUserByUsername(username);
                if (user == null) continue;

                // Accounts
                var bank = new Account("Bank", rnd.Next(1000, 5000));
                var wallet = new Account("Wallet", rnd.Next(100, 1000));
                user.AddAccount(bank);
                user.AddAccount(wallet);

                // Incomes
                user.Transactions.Add(new Transaction(bank.ID) {
                    Type = TransactionType.Income,
                    Amount = rnd.Next(1500, 4000),
                    CategoryInfo = CategoryInfo.IncomeCategories.First(c => c.Description == "Salary"),
                    ReceiverAccount = bank.ID,
                    EffectDate = DateTime.Now.AddDays(-rnd.Next(1, 10)),
                    Description = $"Salary for {displayName}"
                });

                // Expenses
                user.Transactions.Add(new Transaction(wallet.ID) {
                    Type = TransactionType.Expense,
                    Amount = rnd.Next(20, 100),
                    CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Food & Dining"),
                    SenderAccount = wallet.ID,
                    EffectDate = DateTime.Now.AddDays(-rnd.Next(0, 7)),
                    Description = $"Dinner by {displayName}"
                });

                user.Transactions.Add(new Transaction(wallet.ID) {
                    Type = TransactionType.Expense,
                    Amount = rnd.Next(10, 60),
                    CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Transportation"),
                    SenderAccount = wallet.ID,
                    EffectDate = DateTime.Now.AddDays(-rnd.Next(0, 7)),
                    Description = $"Bus ride"
                });

                // Transfer
                user.Transactions.Add(new Transaction(bank.ID) {
                    Type = TransactionType.Transfer,
                    Amount = rnd.Next(50, 300),
                    CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Transfer"),
                    SenderAccount = bank.ID,
                    ReceiverAccount = wallet.ID,
                    EffectDate = DateTime.Now.AddDays(-1),
                    Description = $"Top-up wallet"
                });

                // Budgets
                if (i % 2 == 0) // give every 2nd user a budget
                {
                    var category = CategoryInfo.ExpenseCategories.First(c => c.Description == "Entertainment");
                    var accountIds = new List<Guid> { bank.ID, wallet.ID };

                    user.Budgets.Add(new Budget($"{displayName}'s Entertainment", category, rnd.Next(80, 200), accountIds));
                }
            }
        }


    }
}
