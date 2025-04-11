using ExpenseTracker.Elements;
using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {


        public class DashboardView : ElementView {

            public DashboardView(ElementContainer container) : base(container) {

                this.Name = "Dashboard";
                this.NumRows = 10;
                this.NumCols = 10;
                this.Padding = new Padding(3);
                screenKey = "view";


                var viewTransactions = new BalanceSummaryElement(this) {
                    Title = "Summary",
                    Col = 0,
                    Cols = 10,
                    Row = 0,
                    Rows = 10,
                    AllowDrag = false
                };

                screenBuilders.Add("view", () => new List<Element> {
                        viewTransactions
                    });

                DefaultScreenKey = "view";

            }
        }





    }


}


