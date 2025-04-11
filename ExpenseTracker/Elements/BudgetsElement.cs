

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
using ExpenseTracker.Views.ExpenseTracker;


namespace ExpenseTracker.Elements {
    public partial class BudgetsElement : Element
    {
        public BudgetsElement(ElementView parentView) : base(parentView)
        {
            InitializeComponent();

        }

        public override void Init()
        {
            ;

            lvBudgets.View = View.Details;
            lvBudgets.FullRowSelect = true;
            lvBudgets.MultiSelect = false;
            lvBudgets.Columns.Clear();
            lvBudgets.Columns.Add("Budget Name", 250);
            lvBudgets.Columns.Add("Category", 300);
            lvBudgets.Columns.Add("Account", 300);
            lvBudgets.Columns.Add("AmountLimit", 250);
            lvBudgets.Columns.Add("Spent", 300);
            lvBudgets.MouseDoubleClick += lvBudgets_MouseDoubleClick;

            RefreshBudgetList();
        }

        private void lvBudgets_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            var budget = GetSelectedBudget();

        }
       
        private void RefreshBudgetList()
        {

            lvBudgets.Items.Clear();

            var budgets = Session.CurrentUser?.Budgets;
            if (budgets != null)
            {
                foreach (var budget in budgets)
                {
                   
                    var accountId = budget.AccountsIDs.FirstOrDefault();
                    var account = Session.CurrentUser.Accounts.FirstOrDefault(a => a.ID == accountId);
                    string accountName = account != null ? account.Name : "Unknown";


                    var item = new ListViewItem(budget.Name);
                    item.SubItems.Add(budget.CategoryInfo.Description.ToString());
                    item.SubItems.Add(accountName);
                    item.SubItems.Add(budget.AmountLimit.ToString("F2"));
                    item.SubItems.Add(budget.Spent.ToString("F2"));
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


     

        private void btnAddBudget_Click(object sender, EventArgs e)
        {

            var container = this.Parent as ElementContainer;
            container?.CurrentView?.SwitchScreen("add");
            container?.LockView();
        }

        private void btnEditBudget_Click(object sender, EventArgs e)
        {

            var budget = GetSelectedBudget();
            if (budget == null)
            {
                MessageBox.Show("Please select a budget to edit.");
                return;
            }

            Session.SelectedBudgetId = budget.ID;

            var container = this.Parent as ElementContainer;
            if (container?.CurrentView is BudgetsView view)
            {
                view.SwitchScreen("edit");
                container.LockView();
            }


        }

        private void btnDeleteBudget_Click(object sender, EventArgs e)
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
