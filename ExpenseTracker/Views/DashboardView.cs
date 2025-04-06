using global::ExpenseTracker.Controls;

using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {

        public class DashboardView : ElementView {


            private double bal = 13378.71;
            private WF.Timer timer = new WF.Timer();
            private TotalBalanceElement totalBalance;

            public DashboardView(ElementContainer container, string name = "Dashboard") : base(name, container) { }

            public override void Build() {
                ClearElements();


                this.NumCols = 6;
                this.NumRows = 2;
                timer.Interval = 100;

                totalBalance = new TotalBalanceElement();
                totalBalance.Submit += (s, e) => {
                    totalBalance.TotalBalanceText.Text = $"${bal}";
                };

                totalBalance.BalanceInWalletsText.Text = "$13,627.71";
                totalBalance.BalanceInWalletsText.ForeColor = Color.GreenYellow;
                totalBalance.BalanceInCreditsText.Text = "-$249.00";
                totalBalance.BalanceInCreditsText.ForeColor = Color.Red;
                totalBalance.TotalBalanceText.Text = $"${bal}";
                totalBalance.TotalBalanceText.ForeColor = Color.GreenYellow;
                totalBalance.Collumn = 0;
                totalBalance.Row = 1;
                totalBalance.Cols = 2;
                totalBalance.Rows = 1;
                totalBalance.AllowDrag = false;

                timer.Tick += (s, e) => {
                    bal += 100;
                    totalBalance.TotalBalanceText.Text = $"${bal}";
                };

                totalBalance.Disposed += (s, e) => {
                    timer.Stop();
                    bal = 13378.71;
                };

                //timer.Start(); // maybe let parent decide if/when

                var thisMonth = new Element {
                    GroupBox = { Text = "This Month" },
                    Collumn = 2,
                    Cols = 2,
                    AllowDrag = false
                };

                var lastMonth = new Element {
                    GroupBox = { Text = "Last Month" },
                    Collumn = 4,
                    Cols = 2,
                    AllowDrag = false
                };



                this.AddElements(new List<Element> { totalBalance, thisMonth, lastMonth });
                
            }
        }


    }

}
