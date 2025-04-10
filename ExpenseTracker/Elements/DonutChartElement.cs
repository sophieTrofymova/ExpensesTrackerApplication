using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker {
    public partial class DonutChartElement : Element {
        public DonutChartElement() {
            InitializeComponent();
            ChartPanel.Paint += ChartPanel_Paint;
        }

        private void ChartPanel_Paint(object? sender, PaintEventArgs e) {
            var g = e.Graphics;
            var rect = ((Panel)sender!).ClientRectangle;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // ==== sample data ====
            float income = 50f;
            float expense = 339f;
            float total = income + expense;

            if (total <= 0) return;

            float incomeAngle = (income / total) * 360f;
            float expenseAngle = (expense / total) * 360f;

            // ==== layout ====
            float size = Math.Min(rect.Width, rect.Height) * 0.8f;
            float holeRatio = 0.55f;

            var center = new PointF(rect.Width / 2f, rect.Height / 2f);

            var donutRect = new RectangleF(
                center.X - size / 2,
                center.Y - size / 2,
                size,
                size
            );

            var holeSize = size * holeRatio;
            var innerRect = new RectangleF(
                center.X - holeSize / 2,
                center.Y - holeSize / 2,
                holeSize,
                holeSize
            );

            // ==== draw slices ====
            using (var expenseBrush = new SolidBrush(Color.OrangeRed))
                g.FillPie(expenseBrush, donutRect, 0, expenseAngle);

            using (var incomeBrush = new SolidBrush(Color.ForestGreen))
                g.FillPie(incomeBrush, donutRect, expenseAngle, incomeAngle);

            // draw hole
            g.FillEllipse(Brushes.White, innerRect);

            // ==== draw percentage labels ====
            using (var font = new Font("Segoe UI", 8, FontStyle.Regular)) {
                string expPct = $"{Math.Round(expense / total * 100, 1)}%";
                string incPct = $"{Math.Round(income / total * 100, 1)}%";

                var expPos = new PointF(donutRect.Left + 8, donutRect.Bottom - 20);
                var incPos = new PointF(donutRect.Right - 35, donutRect.Top + 10);

                g.DrawString(expPct, font, Brushes.WhiteSmoke, expPos);
                g.DrawString(incPct, font, Brushes.WhiteSmoke, incPos);
            }
        }

    }
}
