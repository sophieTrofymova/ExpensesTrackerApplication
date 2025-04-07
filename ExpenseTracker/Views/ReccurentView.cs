using ExpenseTracker.Controls;

namespace ExpenseTracker.Views
{
    public class ReccurentView : ElementView
    {
        public ReccurentView( ElementContainer container, string name = "Reccurent") : base(name, container)
        {

        }


        public override void Build()
        {

            base.Build();

            LayoutType = ViewLayoutType.FreeMovement;
            //ViewContainer.NumCollumns = 9;
            //ViewContainer.NumRows = 8;

            //timer.Start();

            var Filter = new Element();
            Filter.GroupBox.Text = "Filter";
            Filter.Col = 1;
            Filter.Row = 1;
            Filter.Cols = 2;
            Filter.Rows = NumRows - 2;
            Filter.AllowDrag = true;
            Filter.Size = new Size(200, 200);

            var transactions = new Element();
            transactions.GroupBox.Text = "Transactions";

            transactions.Col = 3;
            transactions.Row = 1;
            transactions.Cols = 5;
            transactions.Rows = NumRows - 2;
            transactions.AllowDrag = true;
            transactions.Size = new Size(200, 200);

            AddElements(new List<Element> { Filter, transactions });

        }

    }
}
