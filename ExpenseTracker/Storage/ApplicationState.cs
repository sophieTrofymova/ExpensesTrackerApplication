

namespace ExpenseTracker.Storage {
    public partial class ApplicationState {

        // Settings

        private readonly string pathsDefaultLocation = "app.paths.json";
        public ApplicationSettings Settings { get; set; }
        public PathsRegistry Paths { get; set; }
        public List<Theme> Themes { get; set; }




        public ApplicationState() {
            InitPathRegistry();


            // log first
            Log.SetLogFilePath(Paths.GetFilename("Log")); // because log should be accessible from everywhere


            // then data
            LoadData();

        }

        /// <summary>
        /// Loads the path registry from file or creates a new one if missing.
        /// </summary>
        private void InitPathRegistry() {
            Paths = Serializer.LoadData<PathsRegistry>(pathsDefaultLocation) ?? new PathsRegistry();

            // Ensure all necessary paths exist
            Paths.EnsurePathRegistered("Settings", "app.settings.json");
            Paths.EnsurePathRegistered("Accounts", "app.accounts.json");
            Paths.EnsurePathRegistered("Log", "app.log.txt");
            Paths.EnsurePathRegistered("Themes", "app.themes.json");

            // Save the registry if it was modified
            Serializer.SaveData(Paths, pathsDefaultLocation);

        }


        /// <summary>
        /// Loads all necessary application data.
        /// </summary>
        public void LoadData() {
            if (Paths == null)
                throw new InvalidOperationException("Paths registry has not been initialized.");

            // Load settings
            Settings = LoadOrCreate<ApplicationSettings>("Settings");


            InitializeTestData();

            //// Load accounts
            //var accs = LoadOrCreate<List<Account>>("Accounts");
            //// Initialize AccountManager by default
            //AccountManager = new AccountManager(accs);
            //// If no accounts exist and test mode is enabled, register test accounts
            //if (accs.Count == 0 && Settings.TestMode) {
            //    TestData.RegisterAccounts(AccountManager);
            //}


            //// Load market
            //Market = LoadOrCreate<Market>("Market");

            //// Only add test stocks if the market has no stocks
            //if (Market.IsEmpty() && Settings.TestMode) {
            //    TestData.AddStocksToMarket(Market);
            //}
        }


        /// <summary>
        /// Saves all application data.
        /// </summary>
        public void SaveData() {
            if (Paths == null)
                throw new InvalidOperationException("Paths registry has not been initialized.");

            // Save data only if it's not null
            if (Settings != null)
                Serializer.SaveData(Settings, Paths.GetFilename("Settings"));

            //if (AccountManager != null)
            //    Serializer.SaveData(AccountManager.GetAllAccounts(), Paths.GetFilename("Accounts"));

            //if (Market != null)
            //    Serializer.SaveData(Market, Paths.GetFilename("Market"));


        }



        /// <summary>
        /// Generic method to load data from a file, or create and save a default instance if missing.
        /// </summary>
        private T LoadOrCreate<T>(string key) where T : new() {
            if (Paths == null)
                throw new InvalidOperationException("Paths registry has not been initialized.");

            var data = Serializer.LoadData<T>(Paths.GetFilename(key));

            if (data == null) {
                data = new T();
                Serializer.SaveData(data, Paths.GetFilename(key));
            }

            return data;
        }


        public void ResetData() {
            //var accountsFilename = Paths.GetFilename("Accounts");
            //if (File.Exists(accountsFilename)) {
            //    File.Delete(accountsFilename);
            //}

            //AccountManager = new AccountManager();
            //TestData.RegisterAccounts(AccountManager);

            //var marketFilename = Paths.GetFilename("Market");
            //if (File.Exists(marketFilename)) {
            //    File.Delete(marketFilename);
            //}
            //Market = new Market();
            //TestData.AddStocksToMarket(Market);
        }


    }
}
