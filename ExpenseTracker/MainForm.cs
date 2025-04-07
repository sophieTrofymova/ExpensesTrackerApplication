using ExpenseTracker.Controls;
using ExpenseTracker.Views.ExpenseTracker;
using ExpenseTracker.Views;
using ExpenseTracker.Storage;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExpenseTracker {
    public partial class MainForm : Form {



        public static ApplicationState AppState;


        public MainForm() {

            // windows form constructor
            InitializeComponent();

            // separate logic for borderless form
            InitializeBorderlessWindow();

            // actual logic initialization
            InitializeApplication();

        }

        // this allows to control anything from anywhere
        // and concerns are still separated
        DashboardView dashboardView;
        TransactionsView transactionsView;
        ReccurentView reccurentView;
        AccountsView accountsView;
        BudgetsView budgetsView;
        ChartsView chartsView;
        SettingsView settingsView;


        /// <summary>
        ///  Here we can initialize starting views params
        ///  by accessing their public controls
        /// </summary>
        private void InitViews() {
            dashboardView = new DashboardView(ViewContainer);
            transactionsView = new TransactionsView(ViewContainer);
            reccurentView = new ReccurentView(ViewContainer);
            accountsView = new AccountsView(ViewContainer);
            budgetsView = new BudgetsView(ViewContainer);
            chartsView = new ChartsView(ViewContainer);
            settingsView = new SettingsView(ViewContainer);
        }

        /// <summary>
        /// This method is used to initialize Actual application concerns   
        /// </summary>
        public void InitializeApplication() {

            // force container to update its size corretly when form returns from
            // maximized view
            this.Resize += (s, e) => {
                ViewContainer.PerformLayout();
                ViewContainer.Invalidate();
            };

            Application.ApplicationExit += (s, e) => {
                // save on exit
                AppState.SaveData();
            };

            //  initialize icons fonts in case they arent loaded
            MaterialFont.UseEmbeddedLoad = true; // use embedded font
            MaterialFont.Initialize(); // initialize Google Material Icons font 

            AppState = new ApplicationState();
           var users = AppState.UserManager.GetAllUsers();

            LoginForm loginForm = new LoginForm(AppState.UserManager, AppState.Settings.TestMode);
            if (loginForm.ShowDialog() != DialogResult.OK) {
                // or close the Application 
                this.Close();
                // and exit this method
                // cause Form.Close() doesn't ensure immediate closure
                return;
            }


     
            // initilize views
            InitViews();
        }



        private void bNavBarToogle_Click(object sender, EventArgs e) {
            NavBar.Visible = !NavBar.Visible;
        }

        private void NavBar_ButtonClicked(object sender, NavBarButtonClickEventArgs e) {

            ViewNameText.Text = e.ClickedButton.TextLabel.Text;

            switch (e.ClickedButton.Name) {

                case nameof(navDashboard): ViewContainer.SetView(dashboardView); break;
                case nameof(navTransactions): ViewContainer.SetView(transactionsView); break;
                case nameof(navReccurent): ViewContainer.SetView(reccurentView); break;
                case nameof(navAccounts): ViewContainer.SetView(accountsView); break;
                case nameof(navBudgets): ViewContainer.SetView(budgetsView); break;
                case nameof(navCharts): ViewContainer.SetView(chartsView); break;
                case nameof(navSettings): ViewContainer.SetView(settingsView); break;
                default: ViewContainer.SetView(dashboardView); break;

            }

        }

        public void DefaultView() {
            ViewContainer.SetView(dashboardView);
        }

        private void ViewContainer_Load(object sender, EventArgs e) {

            ViewNameText.Text = navDashboard.TextLabel.Text;
            ViewContainer.SetView(dashboardView);

        }

        private void navTransactions_Load(object sender, EventArgs e) {

        }

    }
}
