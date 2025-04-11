using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTracker.Controls;
using Microsoft.Identity.Client;

namespace ExpenseTracker.Elements
{
    public partial class AddBudgetElement : Element
    {
        public AddBudgetElement(ElementView parentView) : base(parentView)
        {
            InitializeComponent();
        }
        public override void Init()
        {


            addBudgetCategoryDropDown.Items.Clear();
            var expenseCategories = CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray();
            addBudgetCategoryDropDown.Items.AddRange(expenseCategories);


            cbUserAccountsAddBudget.Items.Clear();
            var accounts = Session.CurrentUser?.Accounts.Select(a => a.Name).ToArray();
            cbUserAccountsAddBudget.Items.AddRange(accounts);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bAddBudget_Click(object sender, EventArgs e)
        {

            if (addBudgetCategoryDropDown.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            if (cbUserAccountsAddBudget.SelectedItem == null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            var selectedAccountName = cbUserAccountsAddBudget.SelectedItem.ToString();
            var selectedCategoryDesc = addBudgetCategoryDropDown.SelectedItem.ToString();

            var acc = Session.CurrentUser?.Accounts.FirstOrDefault(a => a.Name == selectedAccountName);
            var cat = CategoryInfo.ExpenseCategories.FirstOrDefault(c => c.Description == selectedCategoryDesc);

            if (acc == null || cat == null)
            {
                MessageBox.Show("Invalid account or category.");
                return;
            }

            string name = $"{selectedCategoryDesc} Budget";
            if (!decimal.TryParse(tbLimitAmount.Text, out decimal amountLimit))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            var existingBudget = Session.CurrentUser.Budgets
                .FirstOrDefault(b =>
                    b.CategoryInfo.Description == cat.Description &&
                    b.AccountsIDs.Contains(acc.ID));

            if (existingBudget != null)
            {
                var result = MessageBox.Show(
                    $"A budget for '{selectedCategoryDesc}' and account '{selectedAccountName}' already exists. Do you want to update it?",
                    "Budget Exists",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    existingBudget.AmountLimit = amountLimit;
                    MessageBox.Show("Budget updated successfully.");
                }
                else
                {
                    return; 
                }
            }
            else
            {
                var newBudget = new Budget(name, cat, amountLimit, new List<Guid> { acc.ID });
                Session.CurrentUser?.Budgets.Add(newBudget);
                MessageBox.Show("Budget added successfully.");
            }

            var container = (this.Parent as ElementContainer);
            container?.UnlockView();
            this.ParentView?.SwitchScreen("view");
        }

        private void bCancelAddBudget_Click(object sender, EventArgs e)
        {

            var container = (this.Parent as ElementContainer);
            container?.UnlockView();
            this.ParentView?.SwitchScreen("view");
        }
    }
}
