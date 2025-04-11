namespace ExpenseTracker {
    public static class Session {


        public static User? CurrentUser { get { return App.State?.UserManager?.LoggedUser; } }

        public static Guid? SelectedAccountId { get; set; } = null;

        public static Guid? SelectedTransactionId { get; set; } = null;

        public static Account? SelectedAccount() {
            return CurrentUser?.Accounts?.FirstOrDefault(a => a.ID == SelectedAccountId);
        }

        public static Transaction? SelectedTransaction() {
            return CurrentUser?.Transactions?.FirstOrDefault(a => a.ID == SelectedTransactionId);
        }

    }


}
