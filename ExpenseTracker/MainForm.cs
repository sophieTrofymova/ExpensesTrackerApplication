using ExpenseTracker.Properties;
using System.Collections;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ExpenseTracker {


    public partial class MainForm : Form {



        public MainForm() {
            InitializeComponent();
        }


        private void bNavBarToogle_Click(object sender, EventArgs e) {
            NavBar.Visible = !NavBar.Visible;
        }

        private void NavBar_ButtonClicked(object sender, NavBarButtonClickEventArgs e) {

            ViewNameText.Text = e.ClickedButton.TextLabel.Text;

            switch (e.ClickedButton.Name) {
                case nameof(navDashboard): DashboardView(); break;
                case nameof(navTransactions): TransactionsView(); break;
                case nameof(navReccurent): ReccurentView(); break;
                case nameof(navAccounts): break;
                case nameof(navBarButton5): break;
                case nameof(navBarButton6): break;
                case nameof(navBarButton7): break;

                default: break;

            }
        }


        private void ViewContainer_Load(object sender, EventArgs e) {

            ViewNameText.Text = navDashboard.TextLabel.Text;
            DashboardView();

        }

        private void navTransactions_Load(object sender, EventArgs e) {

        }
    }
}
