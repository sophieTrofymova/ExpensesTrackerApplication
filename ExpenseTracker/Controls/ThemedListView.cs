using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ExpenseTracker.Storage;

namespace ExpenseTracker.Controls {
    public class ThemedListView : ListView {

        public ThemedListView() {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            OwnerDraw = true;
            View = View.Details;
            FullRowSelect = true;
            BorderStyle = BorderStyle.None;
            HeaderStyle = ColumnHeaderStyle.Nonclickable;

            this.ForeColor = GetColor(ThemeColor.ListViewItemForeColor);
            this.BackColor = GetColor(ThemeColor.ListViewItemBackColor);
            this.UseCompatibleStateImageBehavior = false;
            this.OwnerDraw = true; // make *super* sure this is set

        }


        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e) {
            try {
                var back = GetColor(ThemeColor.ListViewBackColor);
                var fore = GetColor(ThemeColor.ListViewForeColor);
                var border = GetColor(ThemeColor.ListViewBorderColor);

                using var bg = new SolidBrush(back);
                using var txt = new SolidBrush(fore);
                using var pen = new Pen(border);

                e.Graphics.FillRectangle(bg, e.Bounds);
                e.Graphics.DrawRectangle(pen, e.Bounds);
                e.Graphics.DrawString(e.Header.Text, Font, txt, e.Bounds);
            }
            catch (Exception ex) {
                Debug.WriteLine("💥 DrawColumnHeader: " + ex.Message);
            }
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e) {
            var isSel = e.Item.Selected;

            Color back = isSel ? Color.Orange : Color.Red;
            Color fore = isSel ? Color.White : Color.Black;

            using var bg = new SolidBrush(back);
            using var fg = new SolidBrush(fore);

            e.Graphics.FillRectangle(bg, e.Bounds);
            e.Graphics.DrawString(e.Item.Text, Font, fg, e.Bounds);

            Debug.WriteLine($"[DrawItem] {e.Item.Text} sel={isSel} back={back} fore={fore}");
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e) {
            var isSel = e.Item.Selected;

            Color back = isSel ? Color.Orange : Color.Red;
            Color fore = isSel ? Color.White : Color.Black;

            using var bg = new SolidBrush(back);
            using var fg = new SolidBrush(fore);

            e.Graphics.FillRectangle(bg, e.Bounds);
            e.Graphics.DrawString(e.SubItem.Text ?? "", Font, fg, e.Bounds);

            Debug.WriteLine($"[DrawSubItem] {e.SubItem.Text} sel={isSel} back={back} fore={fore}");
        }




        private Color GetColor(ThemeColor key) {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode;
            return isDesignMode
                ? Theme.GetDefaultColor(key)
                : App.State?.CurrentTheme?.GetColor(key) ?? Theme.GetDefaultColor(key);
        }
    }
}
