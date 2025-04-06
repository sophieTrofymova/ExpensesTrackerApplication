using ExpenseTracker.Controls;

namespace ExpenseTracker.Views
{
    public class TransactionsView : ElementView
    {
        public TransactionsView(ElementContainer container, string name = "Transactions") : base(name, container)
        {
            this.NumRows = 8;
            this.NumCols = 9;

        }


        public override void Build()
        {
            ClearElements();

            var filter = new Element();
            filter.GroupBox.Text = "Filter";
            filter.Collumn = 1;
            filter.Row = 1;

            filter.Cols = 2;
            filter.Rows = 6;
            filter.AllowDrag = false;

            var transactions = new Element();
            transactions.GroupBox.Text = "Transactions";
            transactions.Collumn = 3;
            transactions.Row = 1;

            transactions.Cols = 5;
            transactions.Rows = 6;
            transactions.AllowDrag = false;

            AddElements(new List<Element> { filter, transactions });
        }
    }
}
