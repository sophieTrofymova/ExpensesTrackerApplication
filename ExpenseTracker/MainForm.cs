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
            Load += MainForm_Load;


            //this.iconButton1.Click += IconButton1_Click;
        }

        //private void IconButton1_Click(object? sender, EventArgs e) {
        //    // display draggable Panel Settings
        //}

        private void MainForm_Load(object? sender, EventArgs e) {
            navBar1.ButtonClicked += NavBar1_ButtonClicked;
        }

        private void NavBar1_ButtonClicked(object? sender, NavBarButtonClickEventArgs e) {
            this.Text = e.ClickedButton.Name;

            switch (e.ClickedButton.Name) {
                case nameof(navDashboard): DashboardView(); break;
                case nameof(navTransactions): TransactionsView(); break;
                case nameof(navReccurent): break;
                case nameof(navAccounts): break;
                default: break;

            }

            //switch (e.ClickedButton.Name) {
            //    //case nameof(navDashboard): break;
            //    //case nameof(navTransactions): TransactionView(); break;
            //    //case nameof(navReccurent): break;
            //    //case nameof(navAccounts): break;
            //    //case nameof(navBudgets): break;
            //    //case nameof(navCharts): break;
            //    //case nameof(navSettings): break;
            //    //default:
            //        //
            //        //break;
            //}

        }


        public static List<Element> CurrentElements = new List<Element>();

        public void HideElements(List<Element> elements) {
            for (int i = 0; i < elements.Count; i++) {
                if (elements[i].Parent != null) {
                    elements[i].Parent.Controls.Remove(elements[i]);
                }
                CurrentElements.Remove(elements[i]);
                
            }
        }

        public void ShowElements(List<Element> elements, Control parent) {


            if (parent == null)
                return;


            for (int i = 0; i < elements.Count; i++) {
                parent.Controls.Add(elements[i]);
                CurrentElements.Add(elements[i]);
            }
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        double bal = 13378.71;

        private void DashboardView() {
            HideElements(CurrentElements);

            timer.Interval = 100;
        

            var totalBalance = new TotalBalanceElement();
            totalBalance.Submit += TotalBalance_Submit;

            

            ShowElements(new List<Element> {totalBalance }, MainContainer);

            totalBalance.BalanceInWalletsText.Text = "$13,627.71";
            totalBalance.BalanceInWalletsText.ForeColor = Color.GreenYellow;


            totalBalance.BalanceInCreditsText.Text = "-$249.00";

            totalBalance.BalanceInCreditsText.ForeColor = Color.Red;

            totalBalance.TotalBalanceText.Text = $"${bal}";
            totalBalance.TotalBalanceText.ForeColor = Color.GreenYellow;

            timer.Tick += (object? sender, EventArgs e) => { 
                bal += 100; 
                totalBalance.TotalBalanceText.Text = $"${bal}"; 
            };

            totalBalance.Disposed += TotalBalance_Disposed;

            timer.Start();
        }

        private void TotalBalance_Disposed(object? sender, EventArgs e) {
           timer.Stop();
            bal = 13378.71;
        }

        private void TransactionsView() {
            HideElements(CurrentElements);


            var totalBalance = new TotalBalanceElement();
            totalBalance.Location = new Point(100, 50);
            totalBalance.Submit += TotalBalance_Submit;

            ShowElements(new List<Element> { totalBalance }, MainContainer);

        }

        private void TotalBalance_Submit(object? sender, EventArgs e) {
            this.Text = (sender as TotalBalanceElement).Balance.ToString();
        }

        private void navBar1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }



       

        private void iconButton1_Load(object sender, EventArgs e) {

        }
    }
}
