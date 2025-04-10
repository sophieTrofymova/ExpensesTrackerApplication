using ExpenseTracker.Controls;
using ExpenseTracker.Views.ExpenseTracker;
using ExpenseTracker.Views;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Elements;


namespace ExpenseTracker
{

    public partial class MainForm : Form {

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
                App.State.SaveData();
            };

            //  initialize icons fonts in case they arent loaded
            MaterialFont.UseEmbeddedLoad = true; // use embedded font
            MaterialFont.Initialize(); // initialize Google Material Icons font 


            var users = App.State.UserManager.GetAllUsers();


            // initilize views
            InitViews();

            ViewContainer.ViewUnlocked += (s, e) => {
                this.NavBar.Enabled = true;
            };
            ViewContainer.ViewLocked += (s, e) => {
                this.NavBar.Enabled = false;
            };
            ViewContainer.ViewChanged += (s, e) => {
                this.ViewNameText.Text = e.Name;
            };

           // new ControlsTestingForm().ShowDialog();
        }



        private void bNavBarToogle_Click(object sender, EventArgs e) {
            NavBar.Visible = !NavBar.Visible;
        }

        private void NavBar_ButtonClicked(object sender, NavBarButtonClickEventArgs e) {



            var viewName = e.ClickedButton.TextLabel.Text;

            switch (e.ClickedButton.Name) {

                case nameof(navDashboard): SwitchToView(dashboardView); break;
                case nameof(navTransactions): SwitchToView(transactionsView); break;
                case nameof(navReccurent): SwitchToView(reccurentView); break;
                case nameof(navAccounts): SwitchToView(accountsView); break;
                case nameof(navBudgets): SwitchToView(budgetsView); break;
                case nameof(navCharts): SwitchToView(chartsView ); break;
                case nameof(navSettings): SwitchToView(settingsView); break;
                default: DefaultView(); break;

            }

        }

        private void SwitchToView(ElementView view) {
            if (ViewContainer.IsViewLocked) {
                return;
            }
            ViewContainer.SetView(view);
        }

        public void DefaultView() {
            SwitchToView(dashboardView);
        }

        private void ViewContainer_Load(object sender, EventArgs e) {
            DefaultView();
        }

        private void navTransactions_Load(object sender, EventArgs e) {

        }

        private void iconButton1_Click(object sender, EventArgs e) {
            ViewContainer.UnlockView();
        }
    }
}
