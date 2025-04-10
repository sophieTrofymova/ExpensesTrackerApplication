
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
                this.NumRows = 10;
                this.NumCols = 20;

                Padding = new System.Windows.Forms.Padding(25);
            }

            public override void Build() {
                var user = App.State.UserManager.LoggedUser;
                ClearElements();
                this.NumCols = 1;
                this.NumRows = 1;

                var budgetsElement = new BudgetsElement(this) {
                    ThemedGroupBox = { Text = "Budgets" },
                    Col = 0,
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
