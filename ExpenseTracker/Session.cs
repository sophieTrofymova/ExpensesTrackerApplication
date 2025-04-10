namespace ExpenseTracker {
    public static class Session {


        public static User? CurrentUser { get { return App.State?.UserManager?.LoggedUser; } }

        public static Guid? SelectedAccountId { get; set; } = null;

        public static Account? SelectedAccount() {
            return CurrentUser?.Accounts?.FirstOrDefault(a => a.ID == SelectedAccountId);
        }


    }


}
