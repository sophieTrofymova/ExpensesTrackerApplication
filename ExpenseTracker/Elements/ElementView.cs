using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using ExpenseTracker.Controls;


namespace ExpenseTracker.Elements {

    public enum ViewLayoutType {
        GridManual,
        GridAutomatic,
        FreeMovement
    }

    public class ElementView {

        /// <summary>
        /// View display name
        /// </summary>
        public string Name { get; set; }

        // Parent Container
        public ElementContainer? Container { get; private set; }

        // Desired size of the view fallback in case size of a parent unknown
        public Size DesiredSize { get; set; }

        // Padding around the view
        public Padding Padding { get; set; }

        // current list of displayed elements
        public List<Element> Elements { get; set; }

        // current screen key
        protected string screenKey = "default";

        public string ScreenKey {
            get { return screenKey; }
            set {
                screenKey = value;
                Build();
            }
        }

        public string DefaultScreenKey { get; set; } = "default";

        // deffered element creation based on screenKey 
        protected readonly Dictionary<string, Func<List<Element>>> screenBuilders = new();
        public IReadOnlyDictionary<string, Func<List<Element>>> Screens => screenBuilders;


        // screen changed event causes parent container to replace update its controls from elements list
        public delegate void ScreenChangedEventHandler(object sender, string screenKey);
        public event ScreenChangedEventHandler? ScreenChanged;


        /// <summary>
        ///  This defines how the elements are arranged
        /// </summary>
        private ViewLayoutType layoutType = ViewLayoutType.GridManual;

        public ViewLayoutType LayoutType {
            get { return layoutType; }
            set { layoutType = value; }
        }

        // internal grid params
        private int numRows = 1, numCols = 1;

        /// <summary>
        /// Number of Rows
        /// </summary>
        public int NumRows {
            get { return numRows; }
            set { numRows = value > 0 ? value : 1; }
        }

        /// <summary>
        /// Number of Cols
        /// </summary>
        public int NumCols {
            get { return numCols; }
            set { numCols = value > 0 ? value : 1; }
        }




        public ElementView(ElementContainer container) {

            Elements = new List<Element>();
            Container = container;
            Container.SizeChanged += (s, e) => {
                DesiredSize = Container.Size;
                ApplyLayout();
            };
            DesiredSize = Container.Size;
            Padding = new Padding(5);
        }




        public void Build() {
            this.ClearElements();

            if (screenBuilders.Count == 0)
                return;

            // decide which key to actually use
            var keyToUse = (screenKey == "default") ? DefaultScreenKey : screenKey;

            if (!screenBuilders.TryGetValue(keyToUse, out var builder)) {
                // fallback to "default" if current screen key missing
                if (!screenBuilders.TryGetValue("default", out builder)) {
                    builder = () => new List<Element>(); // worst-case fallback
                }
            }

            var elements = builder();
            AddElements(elements);

            foreach (var element in elements) {
                element.Init();
            }
        }




        protected void AddElements(List<Element> _elements) {
            foreach (var element in _elements) {
                if (!Elements.Contains(element)) {
                    Elements.Add(element);
                }
            }
            ApplyLayout();
        }

        protected void RemoveElements(List<Element> _elements) {
            int count = _elements.Count;
            // going backwards to safely handle when _elements == elements (self-removal) same collection is passed
            while (count != 0) {
                Elements.Remove(_elements[count - 1]);
                count--;
            }
            ApplyLayout();
        }

        private void RearrangeElementsOnGrid() {
            if (Elements.Count == 0) return;

            int colWidth = (DesiredSize.Width - Padding.Left - Padding.Right) / numCols;
            int rowHeight = CalculateRowHeight();

            // Clear existing positions
            foreach (var element in Elements) {
                element.Location = Point.Empty;
            }

            // Sort elements by their desired position (if they have position properties)
            var sortedElements = Elements.OrderBy(e => e.Row).ThenBy(e => e.Col).ToList();

            // Place elements in grid
            foreach (var element in sortedElements) {
                int row = Math.Min(element.Row, numRows - 1);
                int col = Math.Min(element.Col, numCols - 1);

                // Find next available spot if the position is occupied
                while (IsPositionOccupied(row, col, element.Cols, element.Rows)) {
                    col++;
                    if (col >= numCols) {
                        col = 0;
                        row++;
                        if (row >= numRows) {
                            // If we run out of space, add more rows
                            numRows++;
                        }
                    }
                }

                element.Location = new Point(
                    col * colWidth + Padding.Left,
                    row * rowHeight + Padding.Top
                );
                element.Width = colWidth * element.Cols;
                element.Height = rowHeight * element.Rows;
            }
        }

        private bool IsPositionOccupied(int row, int col, int cols, int rows) {
            foreach (var element in Elements) {
                if (element.Location.X == col * (DesiredSize.Width / numCols) &&
                    element.Location.Y == row * CalculateRowHeight()) {
                    return true;
                }
            }
            return false;
        }

        private int CalculateRowHeight() {
            if (Elements.Count == 0 || numRows == 0)
                return DesiredSize.Height;

            int totalHeight = DesiredSize.Height - Padding.Top - Padding.Bottom;
            return totalHeight / numRows;
        }

        protected void ApplyLayout() {
            if (DesiredSize.Width <= 0 || DesiredSize.Height <= 0)
                return;

            switch (LayoutType) {
                case ViewLayoutType.GridAutomatic:
                    RearrangeElementsOnGrid();
                    break;

                case ViewLayoutType.GridManual:
                    ArrangeManualGrid();
                    break;

                case ViewLayoutType.FreeMovement:
                    // RearrangeElementsOnGrid();
                    break;
            }
        }

        private void UpdateLayout() { ApplyLayout(); }

        private void ArrangeManualGrid() {
            int colWidth = (DesiredSize.Width - Padding.Left - Padding.Right) / numCols;
            int rowHeight = CalculateRowHeight();

            foreach (var element in Elements) {
                int col = Math.Min(element.Col, numCols - 1);
                int row = Math.Min(element.Row, numRows - 1);

                element.Location = new Point(
                    col * colWidth + Padding.Left,
                    row * rowHeight + Padding.Top
                );
                element.Width = colWidth * element.Cols;
                element.Height = rowHeight * element.Rows;
            }
        }

        protected void ClearElements() { Elements.Clear(); }

        public bool HasScreen(string key) => screenBuilders.ContainsKey(key);


        public void SwitchScreen(string screenKey) {
            this.screenKey = screenKey;
            Build();
            ScreenChanged?.Invoke(this, screenKey);
        }

    }
}


