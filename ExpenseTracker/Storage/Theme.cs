namespace ExpenseTracker.Storage {

    public enum ThemeColor { AccentColor }
    public class Theme {

        public string Name { get; set; }

        private Dictionary<ThemeColor, Color> Colors { get; set; }

        public Theme()
        {
            Colors = new Dictionary<ThemeColor, Color>();
            Colors.Add(ThemeColor.AccentColor, Color.Coral); // Default color   
            
        }
        public Color GetColor(ThemeColor key) {
            if (Colors.TryGetValue(key, out var color))
                return color;

            return Color.Black; // fallback
        }
    }
}
