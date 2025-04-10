

using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views
{
    public class TransactionsView : ElementView {

        public TransactionsView(ElementContainer container) : base(container) {
            this.Name  = "Transactions"; // view name
            this.screenKey = "view";

            this.NumRows = 10;
            this.NumCols = 20;

            Padding = new System.Windows.Forms.Padding(25);


            var screen = new TransactionsElement(this) {
                Title = "Transactions View",
                Col = 0,
                Cols = 20,
                Row = 0,
                Rows = 10,
                AllowDrag = false
            };


            var addExpense = new AddExpenseElement(this) {
                Title = "Add Expense",
                Col = 1,
                Cols = 8,
                Row = 1,
                Rows = 7,
                AllowDrag = false
            };


            var addIncome = new AddIncomeElement(this) {
                Title = "Add Income",
                Col = 1,
                Cols = 8,
                Row = 1,
                Rows = 7,
                AllowDrag = false
            };


            var addTransfer = new AddTransferElement(this) {
                Title = "Add Transfer",
                Col = 1,
                Cols = 8,
                Row = 1,
                Rows = 7,
                AllowDrag = false
            };


            screenBuilders.Add("addTransfer", () => new List<Element> { addTransfer });
            screenBuilders.Add("addIncome", () => new List<Element> { addIncome });
            screenBuilders.Add("addExpense", () => new List<Element> { addExpense });
            screenBuilders.Add("view", () => new List<Element> {screen });


            DefaultScreenKey = "view";

        }


    }
}


