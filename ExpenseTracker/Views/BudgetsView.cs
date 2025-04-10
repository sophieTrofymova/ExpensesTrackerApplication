
using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views
{

    namespace ExpenseTracker
    {
        public class BudgetsView : ElementView {
            public BudgetsView(ElementContainer container) : base(container) 
            {
                this.Name = "Budgets";
                this.NumCols = 6;
                this.NumRows = 2;

                var budgetsElement = new BudgetsElement(this) {
                    ThemedGroupBox = { Text = "Budgets" },
                    Col = 0,
                    Cols = 20,
                    Rows = 10,
                    AllowDrag = true
                };
                screenBuilders.Add("view", () => new List<Element> { budgetsElement });

                Padding = new System.Windows.Forms.Padding(25);

                DefaultScreenKey = "view";
            }

        }

    }

}
