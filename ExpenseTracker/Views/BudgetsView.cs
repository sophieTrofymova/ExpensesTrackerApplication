
using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class BudgetsView : ElementView {
            public BudgetsView(ElementContainer container) : base(container) {
                this.NumRows = 1;
                this.NumCols = 1;



                this.Name = "Budgets";
                screenBuilders.Add("add", () => new List<Element> {
                new AddBudgetElement(this) {

                    Title = "Add Budget",
                    Col = 0,
                    Row = 0,
                    Cols = 1,
                    Rows = 1,
                    AllowDrag = false
                }
            });

                screenBuilders.Add("edit", () => new List<Element> {
                new EditBudgetElement(this) {
                    Title = "Edit Budget",
                    Col = 0,
                    Row = 0,
                    Cols = 1,
                    Rows = 1,
                    AllowDrag = false
                }
            });

                screenBuilders.Add("view", () => new List<Element> {
                new BudgetsElement(this) {
                    Title = "View Budgets",
                    Col = 0,
                    Row = 0,
                    Cols = 1,
                    Rows = 1,
                    AllowDrag = false
                }
            });

                DefaultScreenKey = "view";
                this.Padding = new Padding(3);
            }



        }




    }

}

