using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class SetBudgetForm : Form
    {
        public SetBudgetForm()
        {
            InitializeComponent();
            cmbCategory.Items.AddRange(CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray());
            PopulateAccounts(cmbAccountBudget);
        }

        private void PopulateAccounts(ComboBox cmbAccountBudget)
        {
            if (App.State.UserManager.LoggedUser?.Accounts == null || App.State.UserManager.LoggedUser.Accounts.Count == 0)
            {
                MessageBox.Show("No accounts found. Please add an account first.");
                return;
            }

            cmbAccountBudget.Items.Clear();

            foreach (var account in App.State.UserManager.LoggedUser.Accounts)
            {
                cmbAccountBudget.Items.Add(account.Name);
            }

            if (cmbAccountBudget.Items.Count > 0)
            {
                cmbAccountBudget.SelectedIndex = 0;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSetBudget_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
            {
                string selectedCategoryDescription = cmbCategory.SelectedItem.ToString();
                var selectedCategory = CategoryInfo.ExpenseCategories
                                                    .FirstOrDefault(c => c.Description == selectedCategoryDescription);

                if (selectedCategory != null)
                {
                    if (cmbAccountBudget.SelectedItem != null)
                    {
                        string selectedAccountName = cmbAccountBudget.SelectedItem.ToString();
                        var selectedAccount = App.State.UserManager.LoggedUser
                            .Accounts.FirstOrDefault(a => a.Name == selectedAccountName);

                        if (selectedAccount != null)
                        {
                            decimal limit;
                            if (decimal.TryParse(txtlimitAmount.Text, out limit) && limit >= 0)
                            {
                                var budget = new Budget(
                                    name: $"{selectedCategoryDescription} Budget",
                                    categoryInfo: selectedCategory,
                                    amountLimit: limit,
                                    accountsIDs: new List<Guid> { selectedAccount.ID }
                                );

                                App.State.UserManager.LoggedUser.Budgets.Add(budget);

                                MessageBox.Show($"New budget set: {budget.Name}, Limit: €{budget.AmountLimit}");

                                txtlimitAmount.Text = "";
                                cmbCategory.SelectedIndex = -1;
                                cmbAccountBudget.SelectedIndex = -1;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid budget limit.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selected account is not valid.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an account.");
                    }
                }
                else
                {
                    MessageBox.Show("Selected category is not valid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
