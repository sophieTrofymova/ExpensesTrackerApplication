using ExpenseTracker.Storage;


namespace ExpenseTracker {
    public static class App {

        public static bool DebugMode { get; set; } = true;
        public static bool HardResetOnReload { get; set; } = true;
        public static ApplicationState State { get; set; }
    }
}
