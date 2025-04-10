using ExpenseTracker.Controls;
using ExpenseTracker.Elements;

namespace ExpenseTracker.Views
{
    public class ReccurentView : ElementView
    {
        public ReccurentView( ElementContainer container) : base(container)
        {

            this.Name = "Reccurent";
            LayoutType = ViewLayoutType.FreeMovement;

            var Filter = new Element();
            Filter.ThemedGroupBox.Text = "Filter";
            Filter.Col = 1;
            Filter.Row = 1;
            Filter.Cols = 2;
            Filter.Rows = NumRows - 2;
            Filter.AllowDrag = true;
            Filter.Size = new Size(200, 200);

            var transactions = new Element();
            transactions.ThemedGroupBox.Text = "Transactions";

            transactions.Col = 3;
            transactions.Row = 1;
            transactions.Cols = 5;
            transactions.Rows = NumRows - 2;
            transactions.AllowDrag = true;
            transactions.Size = new Size(200, 200);


            screenBuilders.Add("view", () => new List<Element> { Filter, transactions });
            DefaultScreenKey = "view";

        }



    }
}
