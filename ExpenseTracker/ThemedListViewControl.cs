using ExpenseTracker.Storage;
using System.ComponentModel;
using System.Diagnostics;

namespace ExpenseTracker {
    public partial class ThemedListViewControl : UserControl {

        private readonly VScrollBar _scrollBar;
        private List<ListViewRow> _items = new();
        private int _rowHeight = 32;
        private int _selectedIndex = -1;
        private int _hoverIndex = -1;

        public ThemedListViewControl() {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

            _scrollBar = new VScrollBar {
                Dock = DockStyle.Right
            };
            _scrollBar.Scroll += (s, e) => Invalidate();

            Controls.Add(_scrollBar);

            this.MouseMove += (s, e) => {
                var index = (e.Y + _scrollBar.Value - _rowHeight) / _rowHeight;
                if (index != _hoverIndex) {
                    _hoverIndex = index;
                    Invalidate();
                }
            };

            this.MouseLeave += (s, e) => {
                _hoverIndex = -1;
                Invalidate();
            };

            this.MouseClick += (s, e) => {
                var index = (e.Y + _scrollBar.Value - _rowHeight) / _rowHeight;
                if (index >= 0 && index < _items.Count) {
                    _selectedIndex = index;
                    Invalidate();
                }
            };
        }

        public void SetItems(List<ListViewRow> items) {
            _items = items;
            _scrollBar.Maximum = Math.Max(0, items.Count * _rowHeight - 1);
            _scrollBar.LargeChange = this.ClientSize.Height;
            Invalidate();
        }

        public void RefreshTheme() {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode) {
                e.Graphics.FillRectangle(Brushes.LightGray, this.ClientRectangle);
                e.Graphics.DrawString("ThemedListViewControl", Font, Brushes.Black, new PointF(10, 10));
                return;
            }

            var g = e.Graphics;
            var scrollOffset = _scrollBar.Value;

            var nameColWidth = Width * 0.6f;
            var balanceColX = nameColWidth + 10;
            var contentWidth = Width - _scrollBar.Width;

            // draw header
            var headerBack = GetColor(ThemeColor.ListViewBackColor);
            var headerFore = GetColor(ThemeColor.ListViewForeColor);
            var headerRect = new Rectangle(0, 0, contentWidth, _rowHeight);

            using var headerBackBrush = new SolidBrush(headerBack);
            using var headerForeBrush = new SolidBrush(headerFore);

            g.FillRectangle(headerBackBrush, headerRect);
            g.DrawString("Account Name", Font, headerForeBrush, new PointF(10, 8));
            g.DrawString("Balance", Font, headerForeBrush, new PointF(balanceColX, 8));

            // draw rows
            var offsetY = _rowHeight;

            for (int i = 0; i < _items.Count; i++) {
                int y = offsetY + i * _rowHeight - scrollOffset;
                if (y + _rowHeight < 0 || y > Height) continue;

                var item = _items[i];

                var back = i == _selectedIndex
                    ? GetColor(ThemeColor.ListViewSelectedItemBackColor)
                    : GetColor(ThemeColor.ListViewItemBackColor);

                var fore = i == _selectedIndex
                    ? GetColor(ThemeColor.ListViewSelectedItemForeColor)
                    : GetColor(ThemeColor.ListViewItemForeColor);

                if (i == _hoverIndex && i != _selectedIndex) {
                    back = ControlPaint.Light(back, 0.1f); // hover highlight
                }

                var itemRect = new Rectangle(0, y, contentWidth, _rowHeight);

                using var bgBrush = new SolidBrush(back);
                using var fgBrush = new SolidBrush(fore);

                g.FillRectangle(bgBrush, itemRect);
                g.DrawString(item.AccountName, Font, fgBrush, new PointF(10, y + 8));
                g.DrawString(item.Balance.ToString("C"), Font, fgBrush, new PointF(balanceColX, y + 8));

                g.DrawLine(Pens.DarkGray, 0, y + _rowHeight - 1, contentWidth, y + _rowHeight - 1); // row separator
            }
        }

        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;
            return isDesignMode
                ? Theme.GetDefaultColor(key)
                : App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }
    }

    public class ListViewRow {
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
    }
}



