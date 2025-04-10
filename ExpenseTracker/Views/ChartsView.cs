using ExpenseTracker.Elements;
using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class ChartsView : ElementView {
            public ChartsView(ElementContainer container, string name = "Charts") : base(name, container) { }

            public override void Build() {
                ClearElements();

                var user = App.State.UserManager.LoggedUser;
                this.NumCols = 1;
                this.NumRows = 1;

                //var chart1 = new ReportElement {
                //    ThemedGroupBox = { Text = "Chart 1" },
                //    Col = 0,
                //    Cols = 2,
                //    Rows = 1,
                //    Row = 0,
                //    AllowDrag = false
                //};


                this.AddElements(new List<Element> { });
            }
        }

    }

}
