namespace ExpenseTracker.Storage {

    public enum ThemeColor { AccentColor }
    public class Theme {

        public string Name { get; set; }

        public Dictionary<ThemeColor, Color> Colors { get; set; }

        public Theme()
        {
            
        }

    }
}
