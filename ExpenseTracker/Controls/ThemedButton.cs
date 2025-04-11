using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ExpenseTracker.Storage;

namespace ExpenseTracker.Controls {
    public class ThemedButton : Button {
        private bool _hovered;
        private bool _pressed;

        public ThemedButton() {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }

        protected override void OnMouseEnter(EventArgs e) {
            base.OnMouseEnter(e);
            _hovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e) {
            base.OnMouseLeave(e);
            _hovered = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent) {
            base.OnMouseDown(mevent);
            _pressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent) {
            base.OnMouseUp(mevent);
            _pressed = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if (e?.Graphics == null) return;

            try {
                var g = e.Graphics;
                var borderColor = GetColor(ThemeColor.ButtonBorderColor);
                var backColor = GetColor(ThemeColor.ButtonBackColor);
                var textColor = GetColor(ThemeColor.ButtonForeColor);

                Color actualBack = _pressed
                    ? ControlPaint.Dark(backColor)
                    : _hovered
                        ? ControlPaint.Light(backColor)
                        : backColor;

                using var backBrush = new SolidBrush(actualBack);
                g.FillRectangle(backBrush, ClientRectangle);

                using var borderPen = new Pen(borderColor, 1);
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);

                TextRenderer.DrawText(
                    g,
                    Text,
                    Font,
                    ClientRectangle,
                    textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
            catch (Exception ex) {
                Debug.WriteLine("ThemedButton OnPaint failed: " + ex);
            }
        }

        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;
            return isDesignMode
                ? Theme.GetDefaultColor(key)
                : App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }
    }
}
