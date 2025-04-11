using ExpenseTracker.Elements;
using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class ChartsView : ElementView {
            public ChartsView(ElementContainer container) : base(container) {

                this.Name = "Charts";
                this.NumCols = 10;
                this.NumRows = 10;
                screenKey = "view";

                this.Padding = new Padding(3);

                // example of a chart elements
                //var chart1 = new BarChartElement(this) {
                //    ThemedGroupBox = { Text = "Bar Chart Example" },
                //    Col = 0,
                //    Cols = 2,
                //    AllowDrag = false
                //};

                //var chart2 = new DonutChartElement(this) {
                //    ThemedGroupBox = { Text = "Donut Chart Example" },
                //    Col = 2,
                //    Cols = 2,
                //    AllowDrag = false
                //};

                var chart3 = new ReportElement(this) {
                Title = "Report By Month",
                    Col = 0,
                    Row = 0,
                    Cols = 10,
                    Rows = 10,
                    AllowDrag = false
                };


                screenBuilders.Add("view", () => new List<Element> {
                    //chart1,
                    //chart2,
                    chart3
                });
                DefaultScreenKey = "view";
            }

        }

    }

}
