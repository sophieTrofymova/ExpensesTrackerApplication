using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;


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

        private ElementContainer Container { get; set; }

        public ElementView(string name, ElementContainer container) {
            if (container == null)
                throw new ArgumentNullException();

            Name = name;
            elements = new List<Element>();
            Container = container;
            Container.SizeChanged += (s, e) => ApplyLayout();
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

            int colWidth = (Container.ClientSize.Width - Container.Padding.Left - Container.Padding.Right) / numCols;
            int rowHeight = CalculateRowHeight();

            // Clear existing positions
            foreach (var element in elements) {
                element.Location = Point.Empty;
            }

            // Sort elements by their desired position (if they have position properties)
            var sortedElements = elements.OrderBy(e => e.Row).ThenBy(e => e.Collumn).ToList();

            // Place elements in grid
            foreach (var element in sortedElements) {
                int row = Math.Min(element.Row, numRows - 1);
                int col = Math.Min(element.Collumn, numCols - 1);

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
                    col * colWidth + Container.Padding.Left,
                    row * rowHeight + Container.Padding.Top
                );
                element.Width = colWidth * element.Cols;
                element.Height = rowHeight * element.Rows;
            }
        }

        private bool IsPositionOccupied(int row, int col, int cols, int rows) {
            foreach (var element in elements) {
                if (element.Location.X == col * (Container.ClientSize.Width / numCols) &&
                    element.Location.Y == row * (CalculateRowHeight())) {
                    return true;
                }
            }
            return false;
        }

        private int CalculateRowHeight() {
            if (elements.Count == 0 || numRows == 0)
                return Container.ClientSize.Height;

            int totalHeight = Container.ClientSize.Height - Container.Padding.Top - Container.Padding.Bottom;
            return totalHeight / numRows;
        }

        protected void ApplyLayout() {
            if (Container.ClientSize.Width <= 0 || Container.ClientSize.Height <= 0)
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
            int colWidth = (Container.ClientSize.Width - Container.Padding.Left - Container.Padding.Right) / numCols;
            int rowHeight = CalculateRowHeight();

            foreach (var element in elements) {
                int col = Math.Min(element.Collumn, numCols - 1);
                int row = Math.Min(element.Row, numRows - 1);

                element.Location = new Point(
                    col * colWidth + Container.Padding.Left,
                    row * rowHeight + Container.Padding.Top
                );
                element.Width = colWidth * element.Cols;
                element.Height = rowHeight * element.Rows;
            }
        }

        protected void ClearElements() { elements.Clear(); }
    }
}


