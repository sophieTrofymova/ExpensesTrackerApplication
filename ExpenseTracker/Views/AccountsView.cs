

using ExpenseTracker.Elements;
using ExpenseTracker.Controls;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {
    public class AccountsView : ElementView {

        public AccountsView(ElementContainer container)
            : base(container) {
            this.NumRows = 10;
            this.NumCols = 20;
            this.Padding = new Padding(5);


            screenBuilders.Add("add", () => new List<Element> {
                new AddAccountElement(this) {

                    Title = "Add Account",
                    Col = 0,
                    Row = 0,
                    Cols = 20,
                    Rows = 10,
                    AllowDrag = false
                }
            });

            screenBuilders.Add("edit", () => new List<Element> {
                new EditAccountElement(this) {
                    Title = "Edit Account",
                    Col = 0,
                    Row = 0,
                    Cols = 20,
                    Rows = 10,
                    AllowDrag = false
                }
            });

            screenBuilders.Add("view", () => new List<Element> {
                new ViewAccountsElement(this) {
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
