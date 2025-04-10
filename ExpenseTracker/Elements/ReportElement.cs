using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace ExpenseTracker.Elements
{
    public partial class ReportElement : Element
    {
        public ReportElement(ElementView parentView) : base(parentView) {
            InitializeComponent();

 
        }

        public override void Init() {
            cmbMonth.Items.AddRange(DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToArray());

            int currentMonth = DateTime.Now.Month;
            cmbMonth.SelectedIndex = currentMonth - 1;

            var currentMonthName = DateTimeFormatInfo.CurrentInfo.MonthNames[currentMonth - 1];
            LoadReportWithBars(currentMonthName);

            cmbMonth.SelectedIndexChanged += CmbMonth_SelectedIndexChanged;
        }


        private void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMonth = cmbMonth.SelectedItem.ToString();
            LoadReportWithBars(selectedMonth);
        }

        private void LoadReportWithBars(string monthName)
        {
            panelReport.Controls.Clear();

            int monthNumber = DateTime.TryParseExact(monthName, "MMMM", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime parsedDate) ? parsedDate.Month : DateTime.Now.Month;

            var transactionManager = new TransactionManager
            {
                Transactions = App.State.UserManager.LoggedUser.Transactions
            };
            var transactionsbymonth = transactionManager.GetTransactionsForMonth(monthNumber);

            if (transactionsbymonth.Count == 0)
            {
                Label noDataLabel = new Label
                {
                    Text = "No data for this month",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point(10, 10)
                };
                panelReport.Controls.Add(noDataLabel);
                return;
            }

            var grouped = transactionsbymonth
                .GroupBy(t => t.CategoryDescription)
                .Select(g => new
                {
                    Category = g.Key,
                    Total = g.Sum(t => t.Amount)
                }).ToList();

            decimal grandTotal = grouped.Sum(g => g.Total);
            int top = 10;

            foreach (var item in grouped)
            {
                Label label = new Label
                {
                    Text = $"{item.Category} - {item.Total:C} ({(item.Total / grandTotal * 100):F1}%)",
                    AutoSize = true,
                    Location = new Point(20, top),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                panelReport.Controls.Add(label);
                top += 25;

                ProgressBar bar = new ProgressBar
                {
                    Value = (int)Math.Round((item.Total / grandTotal) * 100),
                    Maximum = 100,
                    Width = panelReport.Width - 40,
                    Height = 20,
                    Location = new Point(20, top),
                    ForeColor = Color.DodgerBlue
                };
                panelReport.Controls.Add(bar);
                top += 35;
            }
        }
    }
}

