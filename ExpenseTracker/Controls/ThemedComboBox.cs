using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ExpenseTracker;
using ExpenseTracker.Storage;

namespace ExpenseTracker.Controls {
    public class ThemedComboBox : ComboBox {

        public ThemedComboBox() {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            bool isDisabled = !this.Enabled;

            if (e?.Graphics == null || Width <= 0 || Height <= 0) return;

            try {
                var g = e.Graphics;

                var backColor = GetColor(ThemeColor.ComboBoxBackColor, isDisabled);
                var foreColor = GetColor(ThemeColor.ComboBoxForeColor, isDisabled);
                var borderColor = GetColor(ThemeColor.AccentColor, isDisabled);


                g.Clear(backColor);

                using var borderPen = new Pen(borderColor, 1);
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);

                var text = this.SelectedItem?.ToString() ?? this.Text ?? "";
                if (!string.IsNullOrWhiteSpace(text)) {
                    var fontToUse = this.Font ?? SystemFonts.DefaultFont;
                    using var textBrush = new SolidBrush(foreColor);
                    g.DrawString(text, fontToUse, textBrush, new RectangleF(4, 2, Width - 20, Height - 4));
                }

                int arrowX = Math.Max(0, Width - 18);
                int arrowY = Math.Max(0, (Height / 2) - 2);
                DrawArrow(g, new Rectangle(arrowX, arrowY, 12, 8), foreColor);
            }
            catch (Exception ex) {
                Debug.WriteLine("💥 OnPaint Exception: " + ex);
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e) {

            bool isDisabled = !this.Enabled;




            if (e.Index < 0) {
                base.OnDrawItem(e);
                return;
            }

            try {

                var isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

                var backColor = isSelected
                    ? GetColor(ThemeColor.ComboBoxSelectedItemBackColor, isDisabled)
                    : GetColor(ThemeColor.ComboBoxBackColor, isDisabled);

                var foreColor = isSelected
                    ? GetColor(ThemeColor.ComboBoxSelectedItemForeColor, isDisabled)
                    : GetColor(ThemeColor.ComboBoxForeColor, isDisabled);


                using var bgBrush = new SolidBrush(backColor);
                using var textBrush = new SolidBrush(foreColor);

                e.Graphics.FillRectangle(bgBrush, e.Bounds);
                var text = Items[e.Index]?.ToString() ?? "";
                e.Graphics.DrawString(text, Font ?? SystemFonts.DefaultFont, textBrush, e.Bounds);
            }
            catch (Exception ex) {
                Debug.WriteLine("OnDrawItem failed: " + ex.Message);
            }
        }

        private void DrawArrow(Graphics g, Rectangle bounds, Color color) {
            Point middle = new Point(bounds.Left + bounds.Width / 2, bounds.Top + bounds.Height / 2);
            Point[] arrow = {
                new Point(middle.X - 4, middle.Y - 2),
                new Point(middle.X + 4, middle.Y - 2),
                new Point(middle.X,     middle.Y + 2)
            };

            using var brush = new SolidBrush(color);
            g.FillPolygon(brush, arrow);
        }

        private Color GetColor(ThemeColor key, bool isDisabled = false) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

            if (isDesignMode || App.State?.CurrentTheme == null)
                return Theme.GetDefaultColor(key);

            var color = App.State.CurrentTheme.GetColor(key);

            // blend into gray if disabled
            if (isDisabled)
                return ControlPaint.Dark(color, 0.5f); // you can tweak that factor

            return color;
        }

    }
}