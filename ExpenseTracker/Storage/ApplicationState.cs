

using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExpenseTracker.Storage {
    public partial class ApplicationState {

        // Settings


        // only paths file have hardcoded location
        private readonly string pathsDefaultLocation = "app.paths.json";
        public ApplicationSettings? Settings { get; set; }
        public PathsRegistry? Paths { get; set; }
        public List<Theme>? Themes { get; set; }
        public UserManager? UserManager { get; set; }

        // do not serialize this just set on start
        public Theme? CurrentTheme { get; set; }


        public ApplicationState() {

            // use hard reset to restore default state
            if (App.HardResetOnReload) {
                HardReset(); // hard itself reloads everything
            }
            else {
                LoadData();
            }

        }


        /// <summary>
        /// Performing hard reset means deleting everything
        /// even paths registry
        /// </summary>
        public void HardReset() {

            // try to load paths registry from file
            Paths = Serializer.LoadData<PathsRegistry>(pathsDefaultLocation);

            // if paths are initialized 
            if (Paths != null) {
                // then we remove all data if it exists
                Paths.GetAllPaths().Keys.ToList().ForEach(key => {
                    if (File.Exists(Paths.GetFilename(key))) {
                        File.Delete(Paths.GetFilename(key));
                    }
                });
            }

            // create new paths registry
            Paths = new PathsRegistry();

            // Ensure all necessary paths exist
            Paths.EnsurePathRegistered("Themes", "app.themes.json");
            Paths.EnsurePathRegistered("Settings", "app.settings.json");
            Paths.EnsurePathRegistered("Users", "app.users.json");
            Paths.EnsurePathRegistered("Log", "app.log.txt");


            // Save the registry if it was modified
            Serializer.SaveData(Paths, pathsDefaultLocation);

            // log 
            Log.SetLogFilePath(Paths.GetFilename("Log")); // log should be accessible from everywhere

            // generate new theme list
            Themes = new List<Theme>();
            // add default theme
            var defaultTheme = new Theme() { Name = "Default" };
            defaultTheme.SetDefaults();
            Themes.Add(new Theme() { Name = "Default" });

            // service method to generate list of basic themes
            // not intended to be used in any other context!
            GenerateDefaultThemes();

            // save default theme
            Serializer.SaveData(Themes, Paths.GetFilename("Themes"));

            // generate new settings
            Settings = new ApplicationSettings() {
                TestMode = App.DebugMode, // set test mode if debug mode is enabled
                ThemeName = "Default",
                CurrencyType = CurrencyType.USD
            };

            // try to set default theme
            // sanity check to ensure that default theme is present
            CurrentTheme = Themes.FirstOrDefault(t => t.Name == "Default");
            if (CurrentTheme == null) {
                throw new InvalidOperationException("Default theme not found!");
            }

            Serializer.SaveData(Settings, Paths.GetFilename("Settings"));

            // create new user manager
            UserManager = new UserManager();

            // generate test users and their data in case of test mode
            if (Settings.TestMode) {

                TestData.GenerateTestUsers(UserManager); // we do not use direct serialization because we need to ensure that user test data still within expected parameters   
            }
            // save regardless, it just going to be empty in release mode, and users can register new account
            Serializer.SaveData(UserManager.GetAllUsers(), Paths.GetFilename("Users"));

        }



        /// <summary>
        /// Example of new theme generation
        /// </summary>
        private void GenerateDefaultThemes() {
            if (Themes == null) {
                throw new InvalidOperationException("Themes list is not initialized, service method called in wrong context!");
            }


            GenerateDarkTheme();
            GenerateLightTheme();


        }

        private void GenerateDarkTheme() {


            // dark theme
            Color GeneralBackColor = Color.FromArgb(30, 30, 30);
            Color GeneralForeColor = Color.WhiteSmoke;

            Dictionary<ThemeColor, Color> darkThemeColors = new() {

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

                { ThemeColor.ListViewBackColor, Color.Coral },
                { ThemeColor.ListViewForeColor, Color.WhiteSmoke },
                { ThemeColor.ListViewBorderColor, Color.Coral },

                { ThemeColor.ListViewItemBackColor, Color.Coral },
                { ThemeColor.ListViewItemForeColor, Color.WhiteSmoke  },
                { ThemeColor.ListViewSelectedItemBackColor, Color.Coral },
                { ThemeColor.ListViewSelectedItemForeColor, Color.WhiteSmoke },
            };

            var darkTheme = new Theme() { Name = "Dark" };
            darkTheme.SetDefaults(); // this ensure all colors keys are set

            // then change any you like 
            foreach (ThemeColor color in darkThemeColors.Keys) {
                darkTheme.SetColor(color, darkThemeColors[color]);
            }
            Themes.Add(darkTheme);
        }

        private void GenerateLightTheme() {
            // light theme

            Color GeneralBackColor = Color.WhiteSmoke;
            Color GeneralForeColor = Color.Black;

            Dictionary<ThemeColor, Color> lightThemeColors = new() {

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

                { ThemeColor.ListViewBackColor, Color.Coral },
                { ThemeColor.ListViewForeColor, Color.WhiteSmoke },
                { ThemeColor.ListViewBorderColor, Color.Coral },

                { ThemeColor.ListViewItemBackColor, Color.Coral },
                { ThemeColor.ListViewItemForeColor, Color.WhiteSmoke  },
                { ThemeColor.ListViewSelectedItemBackColor, Color.Coral },
                { ThemeColor.ListViewSelectedItemForeColor, Color.WhiteSmoke },
            };

            var lightTheme = new Theme() { Name = "Light" };
            lightTheme.SetDefaults(); // this ensure all colors keys are set

            // then change any you like 
            foreach (ThemeColor color in lightThemeColors.Keys) {
                lightTheme.SetColor(color, lightThemeColors[color]);
            }
            Themes.Add(lightTheme);
        }


        /// <summary>
        /// Loads all necessary application data.
        /// </summary>
        public void LoadData() {


            // -- PATHS REGISTRY FILE ----------------------

            bool pathsRegenerated = false;


            if (File.Exists(pathsDefaultLocation)) {
                // try to load paths registry from file
                Paths = Serializer.LoadData<PathsRegistry>(pathsDefaultLocation);
            }

            if (Paths == null) {
                Paths = new PathsRegistry();
                pathsRegenerated = true;
            }

            // Ensure all necessary paths exist
            Paths.EnsurePathRegistered("Settings", "app.settings.json");
            Paths.EnsurePathRegistered("Users", "app.users.json");
            Paths.EnsurePathRegistered("Log", "app.log.txt");
            Paths.EnsurePathRegistered("Themes", "app.themes.json");

            // set log path
            Log.SetLogFilePath(Paths.GetFilename("Log")); // because log should be accessible from everywhere

            if (pathsRegenerated)
                Log.Message($"App were unable to read {nameof(Paths)} file at < {pathsDefaultLocation} >, generating new instance with default values.");

            // Save the registry if it was modified
            Serializer.SaveData(Paths, pathsDefaultLocation);

            if (File.Exists(pathsDefaultLocation)) {
                Log.Message($"File: {nameof(Paths)} at < {pathsDefaultLocation} >, saved successfuly!");
            }



            // -- SETTINGS FILE ----------------------

            if (File.Exists(Paths.GetFilename("Settings"))) {
                Settings = Serializer.LoadData<ApplicationSettings>(Paths.GetFilename("Settings"));
            }

            // If settings are not loaded, create a new instance with default values to make sure that the application can run
            if (Settings == null) {
                Log.Message($"App were unable to read {nameof(Settings)} file at < {Paths.GetFilename("Settings")} >, generating new instance with default values.");
                Settings = new ApplicationSettings() {
                    TestMode = App.DebugMode, // set test mode if debug mode is enabled
                    ThemeName = "Default",
                    CurrencyType = CurrencyType.USD
                };
            }

            Serializer.SaveData(Settings, Paths.GetFilename("Settings"));

            if (File.Exists(Paths.GetFilename("Settings"))) {
                Log.Message($"File: {nameof(Settings)} at < {Paths.GetFilename("Settings")} >, saved successfuly!");
            }

            // -- THEMES FILE ----------------------

            if (File.Exists(Paths.GetFilename("Themes"))) {
                Themes = Serializer.LoadData<List<Theme>>(Paths.GetFilename("Themes"));
            }
            // If themes are not loaded, create a new instance with default values to make sure that the application can run
            if (Themes == null || Themes.Count == 0) {
                Log.Message($"App were unable to read {nameof(Themes)} file at < {Paths.GetFilename("Themes")} >, generating new instance with default values.");
                Themes = new List<Theme>();
                var defaultTheme = new Theme() { Name = "Default" };
                defaultTheme.SetDefaults();
                Themes.Add(defaultTheme);
                GenerateDefaultThemes();
            }

            Serializer.SaveData(Themes, Paths.GetFilename("Themes"));

            if (File.Exists(Paths.GetFilename("Themes"))) {
                Log.Message($"File: {nameof(Themes)} at < {Paths.GetFilename("Themes")} >, saved successfuly!");
            }


            // try to set default theme
            // sanity check to ensure that default theme is present
            CurrentTheme = Themes.FirstOrDefault(t => t.Name == Settings.ThemeName);
            if (CurrentTheme == null) {
                throw new InvalidOperationException("Default theme not found!");
            }

            // -- USERS FILE ----------------------


            UserManager = new UserManager();
            List<User>? users = null;
            if (File.Exists(Paths.GetFilename("Users"))) {
                users = Serializer.LoadData<List<User>>(Paths.GetFilename("Users"));
            }
            // If users are not loaded, create a new instance with default values to make sure that the application can run
            if (users == null) {
                Log.Message($"App were unable to read {nameof(users)} file at < {Paths.GetFilename("Users")} >, generating new instance with default values.");

                // generate test users and their data in case of test mode
                if (Settings.TestMode) {
                    TestData.GenerateTestUsers(UserManager); // we do not use direct serialization because we need to ensure that user test data still within expected parameters   
                }
            }

            // save regardless, it just going to be empty in release mode, and users can register new account
            Serializer.SaveData(UserManager.GetAllUsers(), Paths.GetFilename("Users"));
            if (File.Exists(Paths.GetFilename("Users"))) {
                Log.Message($"File: {nameof(UserManager)} at < {Paths.GetFilename("Users")} >, saved successfuly!");
            }


        }


        /// <summary>
        /// Saves all application data.
        /// </summary>
        public void SaveData() {

            if (Paths != null) {

                Serializer.SaveData(Paths, pathsDefaultLocation);

                if (File.Exists(pathsDefaultLocation)) {
                    Log.Message($"File: {nameof(Paths)} at < {pathsDefaultLocation} >, saved successfuly!");
                }
            }

            if (Themes != null) {
                Serializer.SaveData(Themes, Paths.GetFilename("Themes"));
                if (File.Exists(Paths.GetFilename("Themes"))) {
                    Log.Message($"File: {nameof(Themes)} at < {Paths.GetFilename("Themes")} >, saved successfuly!");
                }
            }

            // Save data only if it's not null
            if (Settings != null) {

                Serializer.SaveData(Settings, Paths.GetFilename("Settings"));

                if (File.Exists(Paths.GetFilename("Settings"))) {
                    Log.Message($"File: {nameof(Settings)} at < {Paths.GetFilename("Settings")} >, saved successfuly!");
                }
            }

            if (UserManager != null) {
                Serializer.SaveData(UserManager.GetAllUsers(), Paths.GetFilename("Users"));
                if (File.Exists(Paths.GetFilename("Users"))) {
                    Log.Message($"File: Users at < {Paths.GetFilename("Users")} >, saved successfuly!");
                }
            }
        }



        ///// <summary>
        ///// Generic method to load data from a file, or create and save a default instance if missing.
        ///// </summary>
        //private T LoadOrCreate<T>(string key) where T : new() {
        //    if (Paths == null)
        //        throw new InvalidOperationException("Paths registry has not been initialized.");

        //    var data = Serializer.LoadData<T>(Paths.GetFilename(key));

        //    if (data == null) {
        //        data = new T();
        //        Serializer.SaveData(data, Paths.GetFilename(key));
        //    }

        //    return data;
        //}








    }
}
