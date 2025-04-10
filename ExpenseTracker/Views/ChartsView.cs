using ExpenseTracker.Elements;
using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class ChartsView : ElementView {
            public ChartsView(ElementContainer container) : base(container) {

                this.Name = "Charts";
                this.NumCols = 6;
                this.NumRows = 2;
                screenKey = "view";

                var chart1 = new BarChartElement {
                    ThemedGroupBox = { Text = "Bar Chart Example" },
                    Col = 0,
                    Cols = 2,
                    AllowDrag = false
                };

                var chart2 = new DonutChartElement {
                    ThemedGroupBox = { Text = "Donut Chart Example" },
                    Col = 2,
                    Cols = 2,
                    AllowDrag = false
                };

                var chart3 = new ReportElement {
                    ThemedGroupBox = { Text = "Chart 1" },
                    Col = 0,
                    Cols = 4,
                    Row = 2,
                    Rows = 2,
                    AllowDrag = false
                };


                screenBuilders.Add("view", () => new List<Element> {
                    chart1,
                    chart2,
                    chart3
                });
                DefaultScreenKey = "view";
            }

        }

    }

}
