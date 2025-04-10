
using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class BudgetsView : ElementView {
            public BudgetsView(ElementContainer container) : base(container) {
                this.NumRows = 1;
                this.NumCols = 1;

                var budgetsElement = new BudgetsElement(this) {
                    Title = "Budgets",
                    Col = 0,
                    Row = 0,
                    Cols = 1,
                    Rows = 1,
                    AllowDrag = true
                };

                screenBuilders.Add("view", () => new List<Element> { budgetsElement });

                Padding = new System.Windows.Forms.Padding(25);

                DefaultScreenKey = "view";


            }




        }

    }

}
