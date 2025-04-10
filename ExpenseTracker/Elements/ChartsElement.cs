using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Elements {
    public partial class BarChartElement : Element {
        public BarChartElement() {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
        }


        public override void Init() {

        }

        private void Panel1_Paint(object? sender, PaintEventArgs e) {

            var g = e.Graphics;
            var rect = ((Panel)sender).ClientRectangle;

            string chartTitle = "Last 7 days";
            string[] xLabels = new[] { "4 Fri", "5 Sat", "6 Sun", "7 Mon", "8 Tue", "9 Wed", "10 Thu" };
            float[] values = new float[] { 120, 15, 75, 30, 55, 25, 5 };

            float paddingTop = 40;
            float paddingBottom = 40;
            float paddingLeft = 50;
            float paddingRight = 20;

            float chartWidth = rect.Width - paddingLeft - paddingRight;
            float chartHeight = rect.Height - paddingTop - paddingBottom;

            float maxVal = values.Max();
            float yStep = 20f; // space between horizontal gridlines
            int steps = (int)Math.Ceiling(maxVal / yStep);

            var chartArea = new RectangleF(paddingLeft, paddingTop, chartWidth, chartHeight);

            // background (light card look)
            g.Clear(Color.White);
            g.FillRectangle(Brushes.WhiteSmoke, rect);

            // draw title
            using (var titleFont = new Font("Segoe UI", 10, FontStyle.Bold)) {
                g.DrawString(chartTitle, titleFont, Brushes.Black, new PointF(paddingLeft, 10));
            }

            // draw horizontal gridlines + Y-axis labels
            using (var gridPen = new Pen(Color.LightGray, 1)) {
                for (int i = 0; i <= steps; i++) {
                    float val = i * yStep;
                    float y = chartArea.Bottom - (val / maxVal * chartArea.Height);

                    g.DrawLine(gridPen, paddingLeft, y, rect.Width - paddingRight, y);
                    g.DrawString($"${val}", SystemFonts.DefaultFont, Brushes.Black, 0, y - 8);
                }
            }

            // calculate bars
            float barSpacing = 8;
            float barWidth = (chartWidth - (barSpacing * (values.Length - 1))) / values.Length;

            // draw bars + labels
            for (int i = 0; i < values.Length; i++) {
                float barHeight = (values[i] / maxVal) * chartArea.Height;
                float x = paddingLeft + i * (barWidth + barSpacing);
                float y = chartArea.Bottom - barHeight;

                // draw bar
                g.FillRectangle(Brushes.OrangeRed, x, y, barWidth, barHeight);

                // draw X label
                var label = xLabels[i];
                var size = g.MeasureString(label, SystemFonts.DefaultFont);
                g.DrawString(label, SystemFonts.DefaultFont, Brushes.Black,
                    x + (barWidth - size.Width) / 2, chartArea.Bottom + 4);
            }



        }
    }
}
