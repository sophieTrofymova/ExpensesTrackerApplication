using System.Net.NetworkInformation;

namespace ExpenseTracker {
    internal static class EntryPoint {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // initialize application state
            App.State = new Storage.ApplicationState();


            var loginForm = new LoginForm(App.State.UserManager, App.State.Settings.TestMode);
            var loginResult = loginForm.ShowDialog();

            if (loginResult != DialogResult.OK) {
                return; // we didn't logged in exit then
            }


            // logged in? then run using main form
            Application.Run(new MainForm());
        }
    }
}