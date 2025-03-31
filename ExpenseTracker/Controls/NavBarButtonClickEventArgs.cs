namespace ExpenseTracker {
    // event args to hold clicked text button & its index
    public class NavBarButtonClickEventArgs : EventArgs {
        public NavBarButton ClickedButton { get; }
        public int ButtonIndex { get; }

        public NavBarButtonClickEventArgs(NavBarButton btn, int idx) {
            ClickedButton = btn;
            ButtonIndex = idx;
        }
    }
}
