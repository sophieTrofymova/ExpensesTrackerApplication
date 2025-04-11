using ExpenseTracker.Elements;
using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class SettingsView : ElementView {
            public SettingsView(ElementContainer container) : base(container) {


                this.Name = "Settings";

                this.NumRows = 10;
                this.NumCols = 10;

                screenBuilders.Add("view", () => new List<Element> {
                new SettingsElement(this) {
                    
                    Title = "Settings",
                    Col = 0,
                    Row = 0,
                    Cols = 10,
                    Rows = 10,
                    AllowDrag = false
                }
            });

                this.Padding = new Padding(3);
                DefaultScreenKey = "view";


            }


        }


    }

}
