using ExpenseTracker.Elements;
using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class SettingsView : ElementView {
            public SettingsView(ElementContainer container) : base(container) {


                this.Name = "Reccurent";

                this.NumRows = 8;
                this.NumCols = 9;

                screenBuilders.Add("view", () => new List<Element> {
                new Element() {

                    Title = "Settings",
                    Col = 1,
                    Row = 1,
                    Cols = 2,
                    Rows = 6,
                    AllowDrag = false
                }
            });
                DefaultScreenKey = "view";


            }


        }


    }

}
