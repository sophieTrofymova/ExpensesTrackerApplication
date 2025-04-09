using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ExpenseTracker.Storage;

namespace ExpenseTracker.Controls {
    public class ThemedGroupBox : GroupBox {


        [Category("Layout")]
        [Description("Padding around the inner border.")]
        [RefreshProperties(RefreshProperties.All)]
        public int BorderPadding { get; set; } = 8;


        public override Rectangle DisplayRectangle {
            get {
                int top = Font.Height + BorderPadding;
                return new Rectangle(
                    BorderPadding,
                    top,
                    Width - BorderPadding * 2,
                    Height - top - BorderPadding
                );
            }
        }




        public ThemedGroupBox() {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);
            this.ForeColor = GetColor(ThemeColor.GroupBoxForeColor);
        }


        protected override void OnControlAdded(ControlEventArgs e) {
            base.OnControlAdded(e);
            PerformLayout(); // force layout to use DisplayRectangle
        }


        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            var g = e.Graphics;


            var borderColor = GetColor(ThemeColor.GroupBoxHeaderBorderColor);
            var textColor = GetColor(ThemeColor.GroupBoxHeaderForeColor);
            var backColor = GetColor(ThemeColor.GroupBoxBackColor);

            g.Clear(backColor);

            var text = this.Text;
            var font = this.Font ?? SystemFonts.DefaultFont;
            var textSize = g.MeasureString(text, font);
            int captionY = BorderPadding + (int)(textSize.Height / 2);

            int left = BorderPadding;
            int right = Width - BorderPadding;
            int bottom = Height - BorderPadding;

            using var pen = new Pen(borderColor);
            using var textBrush = new SolidBrush(textColor);

            // top (break for caption)
            g.DrawLine(pen, left, captionY, left + 6, captionY);
            g.DrawLine(pen, left + 6 + (int)textSize.Width + 4, captionY, right, captionY);

            // sides + bottom
            g.DrawLine(pen, left, captionY, left, bottom);
            g.DrawLine(pen, right, captionY, right, bottom);
            g.DrawLine(pen, left, bottom, right, bottom);

            g.DrawString(text, font, textBrush, left + 6, BorderPadding);
        }


        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;

            if (isDesignMode)
                return Theme.GetDefaultColor(key);

            return App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }

    }
}
