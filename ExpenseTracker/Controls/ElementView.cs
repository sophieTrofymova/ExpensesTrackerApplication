using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;


namespace ExpenseTracker.Controls {

    public enum ViewLayoutType {
        GridManual,
        GridAutomatic,
        FreeMovement
    }

    public class ElementView {
        public string Name { get; private set; }

        private List<Element> elements;


        private ViewLayoutType layoutType = ViewLayoutType.GridManual;

        int numRows = 1, numCols = 1;

        public ViewLayoutType LayoutType {
            get { return layoutType; }
            set { layoutType = value; }
        }

        public int NumRows {
            get { return numRows; }
            set { numRows = (value > 0) ? value : 1; }
        }

        public int NumCols {
            get { return numCols; }
            set { numCols = (value > 0) ? value : 1; }
        }

 
        public Size DesiredSize { get; set; } 
        public Padding Padding { get; set; }
        private ElementContainer? container = null;

        public ElementView(string name, ElementContainer _container) {

            this.container = _container; 
            Name = name;
            elements = new List<Element>();
            container.SizeChanged += Container_SizeChanged;
            DesiredSize = new Size(1920,1080);
            Padding = new Padding(5);

        }

        private void Container_SizeChanged(object? sender, EventArgs e) {
            this.DesiredSize = this.container.Size;
            ApplyLayout();
        }

        /// <summary>
        /// Called everytime the view is swithced to.
        /// </summary>
        public virtual void Build() {
            // just clear n noop here
            elements.Clear();
        }

        public List<Element> GetAllElements() { return elements; }

        protected void AddElements(List<Element> _elements) {
            foreach (var element in _elements) {
                if (!this.elements.Contains(element)) {
                    this.elements.Add(element);
                }
            }
            ApplyLayout();
        }

        protected void RemoveElements(List<Element> _elements) {
            int count = _elements.Count;
            // going backwards to safely handle when _elements == elements (self-removal) same collection is passed
            while (count != 0) {
                this.elements.Remove(_elements[count - 1]);
                count--;
            }
            ApplyLayout();
        }

        private void RearrangeElementsOnGrid() {
            if (elements.Count == 0) return;

            int colWidth = (DesiredSize.Width - Padding.Left - Padding.Right) / numCols;
            int rowHeight = CalculateRowHeight();

            // Clear existing positions
            foreach (var element in elements) {
                element.Location = Point.Empty;
            }

            // Sort elements by their desired position (if they have position properties)
            var sortedElements = elements.OrderBy(e => e.Row).ThenBy(e => e.Col).ToList();

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
            foreach (var element in elements) {
                if (element.Location.X == col * (DesiredSize.Width / numCols) &&
                    element.Location.Y == row * (CalculateRowHeight())) {
                    return true;
                }
            }
            return false;
        }

        private int CalculateRowHeight() {
            if (elements.Count == 0 || numRows == 0)
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

            foreach (var element in elements) {
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

        protected void ClearElements() { elements.Clear(); }
    }
}


