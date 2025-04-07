using global::ExpenseTracker.Controls;
using System.Globalization;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {

        // MainForm
        // 


        public class DashboardView : ElementView {

            

            public BalanceSummaryElement BalanceSummary;

            public DashboardView(ElementContainer container, string name = "Dashboard") : base(name, container) { }

            public override void Build() {
                ClearElements();

                // view layout
                this.NumCols = 24;
                this.NumRows = 24;


                // create element
                BalanceSummary = new BalanceSummaryElement();
                BalanceSummary.Title = "Summary";
                
                // pos
                BalanceSummary.Collumn = 1;
                BalanceSummary.Row = 1;

                // how many cols and rows it takes
                BalanceSummary.Cols = 22;
                BalanceSummary.Rows = 22;
                BalanceSummary.AllowDrag = false;


                BalanceSummary.DisplayAccounts(MainForm.AppState.UserManager.LoggedUser.Accounts);

                this.AddElements(new List<Element> { BalanceSummary });
            }

          

        }


    }

}
