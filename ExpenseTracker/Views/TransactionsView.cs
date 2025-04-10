

using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views
{
    public class TransactionsView : ElementView {

        private ListView transactionListView;
        public TransactionsView(ElementContainer container) : base(container) {
            this.Name  = "Transactions";
            this.screenKey = "view";
            this.NumRows = 10;
            this.NumCols = 20;

            Padding = new System.Windows.Forms.Padding(25);


            screenBuilders.Add("view", () => new List<Element> {
                new TransactionsElement {
                    Title = "Transactions View",
                    Col = 0,
                    Cols = 20,
                    Row = 0,
                    Rows = 10,
                    AllowDrag = false
                }
            });
            DefaultScreenKey = "view";

        }


    }
}


