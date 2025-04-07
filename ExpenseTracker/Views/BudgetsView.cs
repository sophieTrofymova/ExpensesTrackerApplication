using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class BudgetsView : ElementView {
            public BudgetsView(ElementContainer container, string name = "Budgets") : base(name, container) { }

            public override void Build() {
                ClearElements();
                this.NumCols = 6;
                this.NumRows = 2;

                var budgets = new Element {
                    GroupBox = { Text = "Budgets" },
                    Col = 0,
                    Cols = 6,
                    AllowDrag = false
                };

                this.AddElements(new List<Element> { budgets });
            }
        }

    }

}
