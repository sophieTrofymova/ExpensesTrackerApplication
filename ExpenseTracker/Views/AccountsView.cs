

using ExpenseTracker.Elements;
using ExpenseTracker.Controls;


namespace ExpenseTracker.Views {
    public class AccountsView : ElementView {

        public AccountsView(ElementContainer container)
            : base(container) {
            this.NumRows = 10;
            this.NumCols = 20;
            Padding = new Padding(25);

            this.screenKey = screenKey;

            screenBuilders.Add("add", () => new List<Element> {
                new AddAccountElement {
                    Title = "Add Account",
                    Col = 0,
                    Row = 0,
                    Cols = 20,
                    Rows = 10,
                    AllowDrag = false
                }
            });

           screenBuilders.Add("view", () => new List<Element> {
                new ViewAccountsElement {
                    Title = "View Accounts",
                    Col = 0,
                    Row = 0,
                    Cols = 20,
                    Rows = 10,
                    AllowDrag = false
                }
            });

            DefaultScreenKey = "view";

        }





    }


}
