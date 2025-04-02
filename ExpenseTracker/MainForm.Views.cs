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
            ViewContainer.LayoutType = ElementContainerLayout.GridManual;

            timer.Interval = 100;

            var totalBalance = new TotalBalanceElement();
            totalBalance.Submit += TotalBalance_Submit;

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


            timer.Tick += (object? sender, EventArgs e) => {
                bal += 100;
                totalBalance.TotalBalanceText.Text = $"${bal}";
            };

            totalBalance.Disposed += TotalBalance_Disposed;

            //timer.Start();

            var thisMonth = new Element();
            thisMonth.GroupBox.Text = "This Month";
            thisMonth.Collumn = 2;
            thisMonth.Cols = 2;
            thisMonth.AllowDrag = false;

            var lastMonth = new Element();
            lastMonth.GroupBox.Text = "Last Month";
            lastMonth.Collumn = 4;
            lastMonth.Cols = 2;
            lastMonth.AllowDrag = false;


            ViewContainer.AddElements(new List<Element> { totalBalance, thisMonth, lastMonth });
        
        }

        private void TotalBalance_Disposed(object? sender, EventArgs e) {
            timer.Stop();
            bal = 13378.71;
        }

        private void TransactionsView() {

            ViewContainer.HideElements(ViewContainer.Elements);
            ViewContainer.LayoutType = ElementContainerLayout.GridManual;
            ViewContainer.NumCollumns = 9;
            ViewContainer.NumRows = 8;



            //timer.Start();

            var Filter = new Element();
            Filter.GroupBox.Text = "Filter";
            Filter.Collumn = 1;
            Filter.Row = 1;

            Filter.Cols = 2;
            Filter.Rows = ViewContainer.NumRows - 2;
            Filter.AllowDrag = false;

            var transactions = new Element();
            transactions.GroupBox.Text = "Transactions";

            transactions.Collumn = 3;
            transactions.Row =1 ;

            transactions.Cols = 5;
            transactions.Rows = ViewContainer.NumRows - 2;
            transactions.AllowDrag = false;


            ViewContainer.AddElements(new List<Element> { Filter, transactions });


        }

        private void ReccurentView() {
        
            ViewContainer.HideElements(ViewContainer.Elements);


           
            ViewContainer.AddElements(new List<Element> {  });
        
        }

        private void AccountsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.AddElements(new List<Element> { });
        }

        private void BudgetsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.AddElements(new List<Element> {  });
        }

        private void ChartsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.AddElements(new List<Element> { });
        }

        private void SettingsView() {
            ViewContainer.HideElements(ViewContainer.Elements);



            ViewContainer.AddElements(new List<Element> { });
        }





    }
}
