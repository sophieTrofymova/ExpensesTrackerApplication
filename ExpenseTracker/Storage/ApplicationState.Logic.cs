

namespace ExpenseTracker.Storage {
    public partial class ApplicationState {

       

        // data

        public User currentUser;
        public List<Transaction> transactions = new List<Transaction>();
        public List<Budget> budgets = new List<Budget>();

        private void InitializeTestData() {

            currentUser = new User("JohnDoe", "password1", "john.doe@email.com", "John Doe");

            Account bankAccount = new Account("Bank", 1500.00m, CurrencyType.EUR);
            Account wallet = new Account("Wallet", 200.50m, CurrencyType.EUR);

            currentUser.AddAccount(bankAccount);
            currentUser.AddAccount(wallet);

            Transaction transaction1 = new Transaction(Guid.NewGuid()) {
                Type = TransactionType.Expense,
                Amount = 50.00m,
                CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Food & Dining"),
                EffectDate = DateTime.Now,
                Description = "Lunch at a restaurant"
            };

            transactions.Add(new Transaction(bankAccount.ID) {
                Type = TransactionType.Income,
                Amount = 2000.00m,
                CategoryInfo = CategoryInfo.IncomeCategories.First(c => c.Description == "Salary"),
                ReceiverAccount = bankAccount.ID,
                EffectDate = DateTime.Now.AddDays(-5),
                Description = "Monthly salary from employer"
            });

            transactions.Add(new Transaction(wallet.ID) {
                Type = TransactionType.Expense,
                Amount = 50.00m,
                CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Food & Dining"),
                SenderAccount = wallet.ID,
                EffectDate = DateTime.Now.AddDays(-2),
                Description = "Lunch at a restaurant"
            });


            transactions.Add(new Transaction(bankAccount.ID) {
                Type = TransactionType.Transfer,
                Amount = 200.00m,
                CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Transfer"),
                SenderAccount = bankAccount.ID,
                ReceiverAccount = wallet.ID,
                EffectDate = DateTime.Now,
                Description = "Transferred money from bank to wallet"
            });

            CategoryInfo entertainmentCategory = CategoryInfo.ExpenseCategories.First(c => c.Description == "Entertainment");
            budgets.Add(new Budget(wallet.ID, entertainmentCategory, 100.00m));
        }

    }
}
