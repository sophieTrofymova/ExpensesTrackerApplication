namespace ExpenseTracker.Storage {

    public enum ThemeColor { AccentColor, ElementBackColor, CaptionColor, ControlBack }
    public class Theme {

        public string Name { get; set; }

        private Dictionary<ThemeColor, Color> Colors { get; set; }

        public Theme()
        {
            Colors = new Dictionary<ThemeColor, Color>();
            Colors.Add(ThemeColor.AccentColor, Color.Coral);  
            Colors.Add(ThemeColor.ElementBackColor, Color.FromArgb(61, 61, 61));
            Colors.Add(ThemeColor.CaptionColor, Color.WhiteSmoke);  Colors.Add(ThemeColor.ControlBack, Color.FromArgb(30, 30, 30));
        }
        public Color GetColor(ThemeColor key) {
            if (Colors.TryGetValue(key, out var color))
                return color;

            return Color.Black; // fallback
        }
    }
}
