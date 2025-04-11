
namespace ExpenseTracker
{
    public static class Session
    {


        public static User? CurrentUser { get { return App.State?.UserManager?.LoggedUser; } }

        public static Guid? SelectedAccountId { get; set; } = null;

        public static Guid? SelectedTransactionId { get; set; } = null;

        public static Guid? SelectedBudgetId { get; set; } = null;




        public static Budget? SelectedBudget()
        {
            return CurrentUser?.Budgets?.FirstOrDefault(a => a.ID == SelectedBudgetId);
        }

        public static Account? SelectedAccount()
        {
            return CurrentUser?.Accounts?.FirstOrDefault(a => a.ID == SelectedAccountId);
        }

        public static Transaction? SelectedTransaction()
        {
            return CurrentUser?.Transactions?.FirstOrDefault(a => a.ID == SelectedTransactionId);
        }

    }


}
