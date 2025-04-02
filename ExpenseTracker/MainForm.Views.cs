using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {


    // this is just to stop IDE from gereating resource file for form
    // cause for forms classes to work as forms they need to be a first class in file
    public class PreventResourceFileGeneration { }


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


            ViewContainer.ShowElements(new List<Element> { totalBalance });
        
        }

        private void TotalBalance_Disposed(object? sender, EventArgs e) {
            timer.Stop();
            bal = 13378.71;
        }

        private void TransactionsView() {

            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.ShowElements(new List<Element> {  });
        
        }
        
        private void ReccurentView() {
        
            ViewContainer.HideElements(ViewContainer.Elements);


           
            ViewContainer.ShowElements(new List<Element> {  });
        
        }

        private void AccountsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.ShowElements(new List<Element> { });
        }

        private void BudgetsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.ShowElements(new List<Element> {  });
        }

        private void ChartsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.ShowElements(new List<Element> { });
        }

        private void SettingsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.ShowElements(new List<Element> { });
        }





    }
}
