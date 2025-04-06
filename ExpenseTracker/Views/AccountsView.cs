using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class AccountsView: ElementView {
            public AccountsView(ElementContainer container, string name = "Accounts") : base(name, container) { }

            public override void Build() {
                base.Build();

                this.NumCols = 6;
                this.NumRows = 2;

                var accounts = new Element {
                    GroupBox = { Text = "Accounts" },
                    Collumn = 0,
                    Cols = 6,
                    AllowDrag = false
                };

                this.AddElements(new List<Element> { accounts });
            }
        }

    }

}
