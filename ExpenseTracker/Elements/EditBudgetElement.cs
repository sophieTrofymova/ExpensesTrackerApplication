using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Elements
{
    public partial class EditBudgetElement : Element
    {
        private Budget? budgetToEdit = null;
        public EditBudgetElement(ElementView parentView) : base(parentView)
        {
            InitializeComponent();
        }
       
        public override void Init()
        {
            budgetToEdit = Session.SelectedBudget();

            if (budgetToEdit == null)
            {
                MessageBox.Show("No budget selected.");
                ReturnToBudgetsScreen();
                return;
            }

            editBudgetCategoryDropDown.Items.Clear();
            editBudgetCategoryDropDown.Items.Add(budgetToEdit.CategoryInfo.Description); 
            editBudgetCategoryDropDown.SelectedIndex = 0;
            editBudgetCategoryDropDown.Enabled = false;

            var accountId = budgetToEdit.AccountsIDs.FirstOrDefault();
            var account = Session.CurrentUser.Accounts.FirstOrDefault(a => a.ID == accountId);
            string accountName = account != null ? account.Name : "Unknown";


            cbUserAccountsEditBudget.Items.Clear();
            cbUserAccountsEditBudget.Items.Add(accountName);
            cbUserAccountsEditBudget.SelectedIndex = 0;
            cbUserAccountsEditBudget.Enabled = false;

            tbLimitAmountEdit.Text = budgetToEdit.AmountLimit.ToString("F2");
        }


        private void ReturnToAccountsScreen()
        {
            var container = this.ParentView?.Container;

            if (container == null)
            {
                throw new NullReferenceException("Parent container is not set");
            }

            container?.UnlockView();
            container?.CurrentView?.SwitchScreen("view");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToAccountsScreen();

        }
        private void bAEditBudget_Click(object sender, EventArgs e)
        {

            if (budgetToEdit == null)
            {
                MessageBox.Show("No budget to update.");
                return;
            }

            if (!decimal.TryParse(tbLimitAmountEdit.Text.Trim(), out decimal newLimit))
            {
                MessageBox.Show("Please enter a valid number for limit.");
                return;
            }

            budgetToEdit.AmountLimit = newLimit;

            MessageBox.Show($"Budget '{budgetToEdit.Name}' updated with limit €{newLimit:F2}");
            ReturnToBudgetsScreen();
        }
        private void ReturnToBudgetsScreen()
        {
            var container = this.ParentView?.Container;
            container?.UnlockView();
            container?.CurrentView?.SwitchScreen("view");
        }
        private void bCancelEditBudget_Click(object sender, EventArgs e)
        {
            ReturnToBudgetsScreen();

        }
    }
}

