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
        GroupBoxForeColor,

        TextBoxBackColor,
        TextBoxForeColor,
        TextBoxBorderColor,
        TextBoxFocusedBorderColor,

        CheckBoxBackColor,
        CheckBoxForeColor,
        CheckBoxBorderColor,
        CheckBoxCheckedColor,
        CheckBoxFocusedColor,

        LabelBackColor,
        LabelForeColor,

        ButtonBackColor,
        ButtonForeColor,
        ButtonBorderColor,

    }


    public class Theme {

        public string Name { get; set; }

        private static Color GeneralBackColor = Color.FromArgb(30, 30, 30);
        private static Color GeneralForeColor = Color.WhiteSmoke;

        private static Dictionary<ThemeColor, Color> defaultColors = new() {

            { ThemeColor.AccentColor, Color.Coral },
            { ThemeColor.ElementBackColor, Color.FromArgb(61, 61, 61) },
            { ThemeColor.CaptionColor, GeneralForeColor },
            { ThemeColor.ControlBack, GeneralBackColor },

            { ThemeColor.ComboBoxBackColor, GeneralBackColor },
            { ThemeColor.ComboBoxForeColor, GeneralForeColor },
            { ThemeColor.ComboBoxSelectedItemBackColor, Color.Coral },
            { ThemeColor.ComboBoxSelectedItemForeColor, Color.Black },

            { ThemeColor.GroupBoxHeaderForeColor, GeneralForeColor },
            { ThemeColor.GroupBoxHeaderBorderColor, Color.Coral },
            { ThemeColor.GroupBoxBackColor, GeneralBackColor },
            { ThemeColor.GroupBoxForeColor, GeneralForeColor },

            { ThemeColor.TextBoxBackColor,GeneralBackColor },
            { ThemeColor.TextBoxForeColor, GeneralForeColor },
            { ThemeColor.TextBoxBorderColor, Color.Coral },
            { ThemeColor.TextBoxFocusedBorderColor, Color.YellowGreen },

            { ThemeColor.CheckBoxBackColor, GeneralBackColor },
            { ThemeColor.CheckBoxForeColor, GeneralForeColor },
            { ThemeColor.CheckBoxBorderColor, Color.Coral },
            { ThemeColor.CheckBoxCheckedColor, Color.Coral },
            { ThemeColor.CheckBoxFocusedColor, Color.YellowGreen },

            { ThemeColor.LabelBackColor, GeneralBackColor },
            { ThemeColor.LabelForeColor, GeneralForeColor },

            { ThemeColor.ButtonBorderColor, Color.Coral },
            { ThemeColor.ButtonBackColor, GeneralBackColor },
            { ThemeColor.ButtonForeColor, GeneralForeColor },
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
