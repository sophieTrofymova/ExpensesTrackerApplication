namespace ExpenseTracker {

    public enum ElementContainerLayout {
        GridManual,
        GridAutomatic,
        FreeMovement
    }

    public partial class ElementContainer : UserControl {
        public List<Element> Elements = new List<Element>();

        public ElementContainerLayout LayoutType {
            get { return layoutType; }
            set {
                layoutType = value;
                ApplyLayout();
            }
        }
        private ElementContainerLayout layoutType = ElementContainerLayout.GridManual;

        int numRows = 2, numCollumns = 1;
        public int NumRows {
            get { return numRows; }
            set {
                numRows = (value > 0) ? value : 1;
                ApplyLayout();
            }
        }
        public int NumCollumns {
            get { return numCollumns; }
            set {
                numCollumns = (value > 0) ? value : 1;
                ApplyLayout();
            }
        }

        public ElementContainer() {
            InitializeComponent();
            this.AutoScroll = true;
            this.ParentChanged += ElementContainer_ParentChanged;
            this.SizeChanged += (s, e) => ApplyLayout();
        }

        private void ElementContainer_ParentChanged(object? sender, EventArgs e) {
            if (this.Parent != null) {
                this.Parent.SizeChanged += (s, e) => ApplyLayout();
            }
        }

        private void ElementContainer_Load(object? sender, EventArgs e) {
            ApplyLayout();
        }

        public void HideElements(List<Element> elements) {
            int count = elements.Count;

            while (count != 0) {
                if (elements[count - 1].Parent != null) {
                    elements[count - 1].Parent.Controls.Remove(elements[count - 1]);
                }
                Elements.Remove(elements[count - 1]);
                count--;
            }
            //ApplyLayout();
        }

        public void AddElements(List<Element> elements) {
            foreach (var element in elements) {
                if (!Elements.Contains(element)) {
                    Elements.Add(element);
                    this.Controls.Add(element);
                }
            }
            ApplyLayout();
        }

        public void RearrangeElementsOnGrid() {
            if (Elements.Count == 0) return;

            int colWidth = (this.ClientSize.Width - this.Padding.Left - this.Padding.Right) / numCollumns;
            int rowHeight = CalculateRowHeight();

            // Clear existing positions
            foreach (var element in Elements) {
                element.Location = Point.Empty;
            }

            // Sort elements by their desired position (if they have position properties)
            var sortedElements = Elements.OrderBy(e => e.Row).ThenBy(e => e.Collumn).ToList();

            // Place elements in grid
            foreach (var element in sortedElements) {
                int row = Math.Min(element.Row, numRows - 1);
                int col = Math.Min(element.Collumn, numCollumns - 1);

                // Find next available spot if the position is occupied
                while (IsPositionOccupied(row, col, element.Cols, element.Rows)) {
                    col++;
                    if (col >= numCollumns) {
                        col = 0;
                        row++;
                        if (row >= numRows) {
                            // If we run out of space, add more rows
                            numRows++;
                        }
                    }
                }

                element.Location = new Point(
                    col * colWidth + this.Padding.Left,
                    row * rowHeight + this.Padding.Top
                );
                element.Width = colWidth * element.Cols;
                element.Height = rowHeight * element.Rows;
            }
        }

        private bool IsPositionOccupied(int row, int col, int cols, int rows) {
            foreach (var element in Elements) {
                if (element.Location.X == col * (this.ClientSize.Width / numCollumns) &&
                    element.Location.Y == row * (CalculateRowHeight())) {
                    return true;
                }
            }
            return false;
        }

        private int CalculateRowHeight() {
            if (Elements.Count == 0 || numRows == 0)
                return this.ClientSize.Height;

            int totalHeight = this.ClientSize.Height - this.Padding.Top - this.Padding.Bottom;
            return totalHeight / numRows;
        }

        private void ApplyLayout() {
            if (this.ClientSize.Width <= 0 || this.ClientSize.Height <= 0)
                return;

            switch (LayoutType) {
                case ElementContainerLayout.GridAutomatic:
                    RearrangeElementsOnGrid();
                    break;

                case ElementContainerLayout.GridManual:
                    ArrangeManualGrid();
                    break;

                case ElementContainerLayout.FreeMovement:
                    // No automatic arrangement needed
                    break;
            }
        }

        private void ArrangeManualGrid() {
            int colWidth = (this.ClientSize.Width - this.Padding.Left - this.Padding.Right) / numCollumns;
            int rowHeight = CalculateRowHeight();

            foreach (var element in Elements) {
                int col = Math.Min(element.Collumn, numCollumns - 1);
                int row = Math.Min(element.Row, numRows - 1);

                element.Location = new Point(
                    col * colWidth + this.Padding.Left,
                    row * rowHeight + this.Padding.Top
                );
                element.Width = colWidth * element.Cols;
                element.Height = rowHeight * element.Rows;
            }
        }

        private void AddElement(Element element) {
            if (!Elements.Contains(element)) {
                Elements.Add(element);
            }
            this.Controls.Add(element);
            ApplyLayout();
        }
    }
}