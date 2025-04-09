using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ExpenseTracker.Storage;

namespace ExpenseTracker.Controls {
    public class ThemedCheckBox : CheckBox {


        [Category("Appearance")]
        public int CheckBoxSize { get; set; } = 16;


        public ThemedCheckBox() {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if (e?.Graphics == null || Width <= 0 || Height <= 0) return;

            try {
                var g = e.Graphics;

                var backColor = GetColor(ThemeColor.CheckBoxBackColor);
                var borderColor = GetColor(ThemeColor.CheckBoxBorderColor);
                var checkColor = Checked ? GetColor(ThemeColor.AccentColor) : Color.Transparent;
                var textColor = GetColor(ThemeColor.CheckBoxForeColor);
                var focusedColor = GetColor(ThemeColor.CheckBoxFocusedColor);


                g.Clear(backColor);

   

                // respect left padding for checkbox
                int boxX = Padding.Left;
                int boxY = (Height - CheckBoxSize) / 2;
                var boxRect = new Rectangle(boxX, boxY, CheckBoxSize, CheckBoxSize);

                using var borderPen = new Pen(borderColor, 1);
                g.DrawRectangle(borderPen, boxRect);

                if (Checked) {
                    using var checkBrush = new SolidBrush(checkColor);
                    g.FillRectangle(checkBrush, Rectangle.Inflate(boxRect, -3, -3));
                }

                // text position also nudged
                int textX = boxRect.Right + 6;
                var textRect = new Rectangle(textX, 0, Width - textX - Padding.Right, Height);

                TextRenderer.DrawText(
                    g,
                    this.Text,
                    this.Font,
                    textRect,
                    textColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                );
            }
            catch (Exception ex) {
                Debug.WriteLine("💥 ThemedCheckBox paint fail: " + ex);
            }
        }


        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

            if (isDesignMode)
                return Theme.GetDefaultColor(key);

            return App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }
    }
}
