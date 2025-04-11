

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
using ExpenseTracker.Controls;
using ExpenseTracker.Views;


namespace ExpenseTracker.Elements {
    public partial class BudgetsElement : Element
    {
        public BudgetsElement(ElementView parentView) : base(parentView)
        {
            InitializeComponent();
        }

        public override void Init()
        {
            //dgvBudgets.Columns.Clear();
            //dgvBudgets.Rows.Clear();
            //dgvBudgets.Columns.Add("Name", "Budget Name");
            //dgvBudgets.Columns.Add("Category", "Category");
            //dgvBudgets.Columns.Add("AmountLimit", "Limit (€)");
            //dgvBudgets.Columns.Add("Spent", "Spent (€)");
            //dgvBudgets.Columns.Add("Month", "Month");
            //dgvBudgets.Columns.Add("Progress", "Progress");
            //dgvBudgets.MouseDoubleClick += DgvBudgets_MouseDoubleClick;
            //LoadBudgets();

            lvBudgets.View = View.Details;
            lvBudgets.FullRowSelect = true;
            lvBudgets.MultiSelect = false;
            lvBudgets.Columns.Clear();
            lvBudgets.Columns.Add("Budget Name", 250);
            lvBudgets.Columns.Add("Category", 300);
            lvBudgets.Columns.Add("AmountLimit", 250);
            lvBudgets.Columns.Add("Spent", 300);
            lvBudgets.Columns.Add("Progress", 300);
            lvBudgets.MouseDoubleClick += lvBudgets_MouseDoubleClick;

            RefreshBudgetList();
        }

        private void lvBudgets_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RefreshBudgetList()
        {

            lvBudgets.Items.Clear();

            var budgets = Session.CurrentUser?.Budgets;
            if (budgets != null)
            {
                foreach (var budget in budgets)
                {
                    decimal progress = (budget.AmountLimit > 0) ? (budget.Spent / budget.AmountLimit) * 100 : 0;

                    var progressBar = new ProgressBar
                    {
                        Value = (int)progress,
                        Maximum = 100,
                        Width = 100,
                        Height = 20
                    };
                    
                    var item = new ListViewItem(budget.Name);
                    item.SubItems.Add(budget.CategoryInfo.Description.ToString());
                    item.SubItems.Add(budget.AmountLimit.ToString("F2"));
                    item.SubItems.Add(budget.Spent.ToString("F2"));
                    item.SubItems.Add(progressBar.ToString());
                    item.Tag = budget; // keep original Account obj for later use

                    lvBudgets.Items.Add(item);
                }
            }

        }

        private Budget? GetSelectedBudget()
        {
            if (lvBudgets.SelectedItems.Count == 0)
                return null;

            return lvBudgets.SelectedItems[0].Tag as Budget;
        }

        private void LvAccounts_MouseDoubleClick(object? sender, MouseEventArgs e)
        {

            if (lvBudgets.SelectedItems.Count == 0) return;

            var item = lvBudgets.SelectedItems[0];
            var budget = item.Tag as Budget;

            if (budget != null)
            {
                var result = MessageBox.Show($"Delete budget '{budget.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Session.CurrentUser?.Budgets.Remove(budget);
                    RefreshBudgetList();
                }
            }

        }

        private void bAddBudget_Click(object sender, EventArgs e)
        {
            var container = this.Parent as ElementContainer;
            container?.CurrentView?.SwitchScreen("add");
            container?.LockView();

        }

        private void bEditBudget_Click(object sender, EventArgs e)
        {

            var budget = GetSelectedBudget();

            if (budget == null)
            {
                MessageBox.Show("You need to select budget first");
                return;
            }

            //Session.SelectedAccountId = budget.AccountsIDs;

            var container = this.Parent as ElementContainer;
            if (container?.CurrentView is AccountsView view)
            {
                view.SwitchScreen("edit");
                container.LockView();
            }

        }

        private void tbDeleteBudget_Click(object sender, EventArgs e)
        {

            var budget = GetSelectedBudget();
            if (budget == null)
            {
                MessageBox.Show("Please select a budget to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete the budgdet '{budget.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Session.CurrentUser?.Budgets.Remove(budget);
                RefreshBudgetList();
            }
        }
    }
}
