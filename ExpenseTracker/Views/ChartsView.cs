using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class ChartsView : ElementView {
            public ChartsView(ElementContainer container, string name = "Charts") : base(name, container) { }

            public override void Build() {
                ClearElements();
                this.NumCols = 6;
                this.NumRows = 2;

                var chart1 = new Element {
                    ThemedGroupBox = { Text = "Chart 1" },
                    Col = 0,
                    Cols = 2,
                    AllowDrag = false
                };

                var chart2 = new Element {
                    ThemedGroupBox = { Text = "Chart 2" },
                    Col = 2,
                    Cols = 2,
                    AllowDrag = false
                };

                var chart3 = new Element {
                    ThemedGroupBox = { Text = "Chart 3" },
                    Col = 4,
                    Cols = 2,
                    AllowDrag = false
                };

                this.AddElements(new List<Element> { chart1, chart2, chart3 });
            }
        }

    }

}
