using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {
    public partial class MainForm {

        private void TotalBalance_Submit(object? sender, EventArgs e) {
            this.Text = (sender as TotalBalanceElement).Balance.ToString();
        }


        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        double bal = 13378.71;

        private void DashboardView() {
        
            ViewContainer.HideElements(ViewContainer.Elements);
            timer.Interval = 100;

            var totalBalance = new TotalBalanceElement();
            totalBalance.Submit += TotalBalance_Submit;

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

            var newelem = new NewElement();
            newelem.GroupBox.Text = "New Transaction";
            newelem.tbSomeField.Text = "Some Text";
            newelem.bAddTransaction.Click += (object? sender, EventArgs e) => {
                newelem.tbSomeField.Text = "Added";
            };

            newelem.Location = new System.Drawing.Point(totalBalance.Location.X+totalBalance.Width, 0);

            var elem3 = new Element3();
            elem3.GroupBox.Text = "Reccurent";



            ViewContainer.ShowElements(new List<Element> { totalBalance, newelem, elem3 }, ViewContainer);
        
        }

        private void TotalBalance_Disposed(object? sender, EventArgs e) {
            timer.Stop();
            bal = 13378.71;
        }

        private void TransactionsView() {

            ViewContainer.HideElements(ViewContainer.Elements);

            var newelem = new NewElement();
            newelem.GroupBox.Text = "New Transaction";  
            newelem.tbSomeField.Text = "Some Text";
            newelem.bAddTransaction.Click += (object? sender, EventArgs e) => {
                newelem.tbSomeField.Text = "Added";
            };

            ViewContainer.ShowElements(new List<Element> { newelem }, ViewContainer);
        
        }
        
        private void ReccurentView() {
        
            ViewContainer.HideElements(ViewContainer.Elements);


            var elem3 = new Element3();
            elem3.GroupBox.Text = "Reccurent";

           
            ViewContainer.ShowElements(new List<Element> { elem3 }, ViewContainer);
        
        }


    }
}
