
using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class BudgetsView : ElementView {
            public BudgetsView(ElementContainer container, string name = "Budgets") : base(name, container) 
            {
                this.NumRows = 10;
                this.NumCols = 20;

                Padding = new System.Windows.Forms.Padding(25);
            }

            public override void Build() {
                var user = MainForm.AppState.UserManager.LoggedUser;
                ClearElements();
                this.NumCols = 6;
                this.NumRows = 2;

                var budgetsElement = new BudgetsElement() {
                    GroupBox = { Text = "Budgets" },
                    Col = 0,
                    Cols = 20,
                    Rows = 10,
                    AllowDrag = true
                };
                
                this.AddElements(new List<Element> { budgetsElement });
              
            }
        }

    }

}
