using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ExpenseTracker.Storage;

namespace ExpenseTracker.Controls {
    public class ThemedLabel : Label {

        public ThemedLabel() {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor, true);

            this.AutoSize = false; // optional: if you want fixed-size labels
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if (e?.Graphics == null) return;

            try {
                var g = e.Graphics;

                var backColor = GetColor(ThemeColor.ControlBack);
                var textColor = GetColor(ThemeColor.CaptionColor);

                using var backBrush = new SolidBrush(backColor);
                g.FillRectangle(backBrush, this.ClientRectangle);

                TextRenderer.DrawText(
                    g,
                    this.Text,
                    this.Font,
                    this.ClientRectangle,
                    textColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                );
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("💥 ThemedLabel paint fail: " + ex);
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
