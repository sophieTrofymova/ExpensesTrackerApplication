using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace ExpenseTracker.Storage {

    public enum ThemeColor {
        AccentColor,
        ElementBackColor,
        CaptionColor,
        ControlBack,
        ComboBoxBackColor,
        ComboBoxForeColor,
        ComboBoxSelectedItemBackColor,
        ComboBoxSelectedItemForeColor,
        GroupBoxHeaderForeColor,
        GroupBoxHeaderBorderColor,
        GroupBoxBackColor,
        GroupBoxForeColor
    }
    public class Theme {

        public string Name { get; set; }

        private static Dictionary<ThemeColor, Color> defaultColors = new() {
            { ThemeColor.AccentColor, Color.Coral },
            { ThemeColor.ElementBackColor, Color.FromArgb(61, 61, 61) },
            { ThemeColor.CaptionColor, Color.WhiteSmoke },
            { ThemeColor.ControlBack, Color.FromArgb(30, 30, 30) },
            { ThemeColor.ComboBoxBackColor, Color.FromArgb(30, 30, 30) },
            { ThemeColor.ComboBoxForeColor, Color.Orange },
            { ThemeColor.ComboBoxSelectedItemBackColor, Color.Coral },
            { ThemeColor.ComboBoxSelectedItemForeColor, Color.Black },

            { ThemeColor.GroupBoxHeaderForeColor, Color.WhiteSmoke },
            { ThemeColor.GroupBoxHeaderBorderColor, Color.Coral },
            { ThemeColor.GroupBoxBackColor, Color.FromArgb(30, 30, 30) },
            { ThemeColor.GroupBoxForeColor, Color.WhiteSmoke }
        };


        // store private set to file
        [JsonProperty]
        private Dictionary<ThemeColor, Color>? currentColors { get; set; }


        public Theme() {

        }


        public void SetDefaults() {
            currentColors ??= new Dictionary<ThemeColor, Color>();

            foreach (var kvp in defaultColors) {
                if (!currentColors.ContainsKey(kvp.Key)) {
                    currentColors[kvp.Key] = kvp.Value;
                    Log.Message(Name + " theme: " + kvp.Key + " not found, setting to default: " + kvp.Value); // TODO: remove this log when all themes are set
                }
            }
        }

        public Color GetColor(ThemeColor key) {

            // in case it used trying to access not serialized theme
            // but directly created theme object
            // here is some lazy loader
            if (currentColors == null) {
                this.SetDefaults();
            }

            if (currentColors.TryGetValue(key, out var color))
                return color;

            return Color.Black; // fallback
        }

        public void SetColor(ThemeColor key, Color color) {
            if (currentColors == null) {
                this.SetDefaults();
            }

            if (currentColors.ContainsKey(key)) {
                currentColors[key] = color;
            }
            else {
                currentColors.Add(key, color);
            }
        }

        public static Color GetDefaultColor(ThemeColor key) {
            if (defaultColors.TryGetValue(key, out var color))
                return color;

            return Color.Black; // fallback
        }



        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context) {
            SetDefaults(); // patch missing keys 
        }

    }
}
