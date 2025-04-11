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

            if (addBudgetCategoryDropDown.SelectedItem != null)
            {
                var acc = Session.CurrentUser?.Accounts.Select(a => a).Where(a => a.Name == (cbUserAccountsAddBudget.SelectedItem as string)).FirstOrDefault() as Account;
                var cat = CategoryInfo.ExpenseCategories.Select(c => c).Where(c => c.Description == (addBudgetCategoryDropDown.SelectedItem as string)).FirstOrDefault() as CategoryInfo;

                var budget = new Budget()
                {
                    Name = $"{addBudgetCategoryDropDown.SelectedItem} Budget",
                    CategoryInfo = cat,
                    AmountLimit = decimal.Parse(tbLimitAmount.Text),
                    AccountsIDs = new List<Guid> { acc.ID }
                };

                Session.CurrentUser?.Budgets.Add(budget);


                var container = (this.Parent as ElementContainer);
                container?.UnlockView();
                this.ParentView?.SwitchScreen("view");
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }

        private void bCancelAddBudget_Click(object sender, EventArgs e)
        {

            var container = (this.Parent as ElementContainer);
            container?.UnlockView();
            this.ParentView?.SwitchScreen("view");
        }
    }
}
