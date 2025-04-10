using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Elements {
    public partial class BudgetsElement : Element {
        public BudgetsElement() {
            InitializeComponent();
            dgvBudgets.ForeColor = Color.Black;

        }

        public override void Init() {
            dgvBudgets.Columns.Clear();
            dgvBudgets.Rows.Clear();
            dgvBudgets.Columns.Add("Name", "Budget Name");
            dgvBudgets.Columns.Add("Category", "Category");
            dgvBudgets.Columns.Add("AmountLimit", "Limit (€)");
            dgvBudgets.Columns.Add("Spent", "Spent (€)");
            dgvBudgets.Columns.Add("Month", "Month");
            LoadBudgets();
        }


        private void LoadBudgets() {
            dgvBudgets.Rows.Clear();

            var budgets = App.State.UserManager.LoggedUser?.Budgets;
            if (budgets != null) {
                foreach (var budget in budgets) {
                    dgvBudgets.Rows.Add(
                        budget.Name,
                        budget.CategoryInfo.Description,
                        budget.AmountLimit.ToString("F2"),
                        budget.Spent.ToString("F2"),
                        budget.Month.ToString("MMMM yyyy")
                    );
                }
            }
        }

        private void btnAddBudget_Click(object sender, EventArgs e) {
            var form = new SetBudgetForm();
            if (form.ShowDialog() == WF.DialogResult.OK) {
                LoadBudgets();
            }
        }
    }
}