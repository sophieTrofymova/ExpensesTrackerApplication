using global::ExpenseTracker.Controls;

namespace ExpenseTracker.Views {

    namespace ExpenseTracker {
        public class SettingsView: ElementView {
            public SettingsView(ElementContainer container, string name = "Settings") : base(name, container) {
                this.NumRows = 8;
                this.NumCols = 9;
            }

            public override void Build() {
                ClearElements();

                var settings = new Element();
                settings.ThemedGroupBox.Text = "Settings";
                settings.Col = 1;
                settings.Row = 1;

                settings.Cols = 2;
                settings.Rows = 6;
                settings.AllowDrag = false;

                AddElements(new List<Element> { settings });
            }
        }


    }

}
