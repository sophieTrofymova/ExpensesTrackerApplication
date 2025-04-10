using ExpenseTracker.Elements;
using global::ExpenseTracker.Controls;
using System.Globalization;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {

        // MainForm
        // 


        public class DashboardView : ElementView {



            public BalanceSummaryElement BalanceSummary;

            public DashboardView(ElementContainer container) : base(container) {

                this.Name = "Dashboard";
                this.NumRows = 24;
                this.NumCols = 24;
                Padding = new Padding(25);
                screenKey = "view";




                // create element
                BalanceSummary = new BalanceSummaryElement();
                BalanceSummary.Title = "Summary";

                // pos
                BalanceSummary.Col = 1;
                BalanceSummary.Row = 1;

                // how many cols and rows it takes
                BalanceSummary.Cols = 22;
                BalanceSummary.Rows = 22;
                BalanceSummary.AllowDrag = false;


                screenBuilders.Add("view", () => new List<Element> {
                        BalanceSummary
                    });

                DefaultScreenKey = "view";

            }
        }





    }


}


