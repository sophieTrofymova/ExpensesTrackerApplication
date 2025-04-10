//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using WF = System.Windows.Forms;

//namespace ExpenseTracker.Elements
//{
//    public partial class BudgetsElement : Element
//    {
//        public BudgetsElement()
//        {
//            InitializeComponent();


//            dgvBudgets.Columns.Add("Name", "Budget Name");
//            dgvBudgets.Columns.Add("Category", "Category");
//            dgvBudgets.Columns.Add("AmountLimit", "Limit (€)");
//            dgvBudgets.Columns.Add("Spent", "Spent (€)");
//            dgvBudgets.Columns.Add("Month", "Month");
//            LoadBudgets();
//        }

//        private void LoadBudgets()
//        {
//            dgvBudgets.Rows.Clear();

//            var budgets = App.State.UserManager.LoggedUser?.Budgets;
//            if (budgets != null)
//            {
//                foreach (var budget in budgets)
//                {
//                    dgvBudgets.Rows.Add(
//                        budget.Name,
//                        budget.CategoryInfo.Description,
//                        budget.AmountLimit.ToString("F2"),
//                        budget.Spent.ToString("F2"),
//                        budget.Month.ToString("MMMM yyyy")
//                    );
//                }
//            }
//        }

//        private void btnAddBudget_Click(object sender, EventArgs e)
//        {
//            var form = new SetBudgetForm(); 
//            if (form.ShowDialog() == WF.DialogResult.OK)
//            {
//                LoadBudgets();
//            }
//        }
//    }
//}

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

namespace ExpenseTracker.Elements
{
    public partial class BudgetsElement : Element
    {
        private Budget _currentBudget;

        public BudgetsElement()
        {
            InitializeComponent();

            dgvBudgets.Columns.Add("Name", "Budget Name");
            dgvBudgets.Columns.Add("Category", "Category");
            dgvBudgets.Columns.Add("AmountLimit", "Limit (€)");
            dgvBudgets.Columns.Add("Spent", "Spent (€)");
            dgvBudgets.Columns.Add("Month", "Month");
            dgvBudgets.Columns.Add("Progress", "Progress");

            dgvBudgets.CellClick += DgvBudgets_CellClick; // Handle category click
            LoadBudgets();
        }

        private void LoadBudgets()
        {
            dgvBudgets.Rows.Clear();

            var budgets = App.State.UserManager.LoggedUser?.Budgets;
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

                    int rowIndex = dgvBudgets.Rows.Add(
                        budget.Name,
                        budget.CategoryInfo.Description,
                        budget.AccountsIDs.Count > 0 ? App.State.UserManager.LoggedUser.Accounts.FirstOrDefault(a => a.ID == budget.AccountsIDs[0])?.Name : "N/A",
                        budget.AmountLimit.ToString("F2"),
                        budget.Spent.ToString("F2"),
                        budget.Month.ToString("MMMM yyyy"),
                        ""
                    );
                    dgvBudgets.Rows[rowIndex].Cells["Progress"].Value = progressBar;
                }
            }
        }

        private void DgvBudgets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedBudget = App.State.UserManager.LoggedUser?.Budgets[e.RowIndex];
                if (selectedBudget != null)
                {
                    _currentBudget = selectedBudget;

                    cmbCategory.Text = _currentBudget.CategoryInfo.Description;
                    cmbAccountBudget.Items.Clear();
                    cmbAccountBudget.Text = App.State.UserManager.LoggedUser.Accounts
                        .FirstOrDefault(a => a.ID == _currentBudget.AccountsIDs[0])?.Name;
                    txtlimitAmount.Text = _currentBudget.AmountLimit.ToString("F2");

                    gbEditBudget.Text = "Edit Budget";

                    pnlEditBudget.Visible = true; 
                }
            }
        }

     

 


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddNewBudget_Click(object sender, EventArgs e)
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
                                pnlAddBudget.Visible = false;
                                LoadBudgets();
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

        private void btnAddBudget_Click_1(object sender, EventArgs e)
        {
            _currentBudget = null;
            cmbCategory.SelectedIndex = -1;
            gbEditBudget.Text = "Add New Budget";
            cmbCategory.Items.AddRange(CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray());
            foreach (var account in App.State.UserManager.LoggedUser.Accounts)
            {
                cmbAccountBudget.Items.Add(account.Name);
            }

            if (cmbAccountBudget.Items.Count > 0)
            {
                cmbAccountBudget.SelectedIndex = 0;
            }
            pnlEditBudget.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _currentBudget = null;
            cmbCategory.SelectedIndex = -1;
            gbEditBudget.Text = "Edit Budget";
            cmbCategory.Items.AddRange(CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray());
            foreach (var account in App.State.UserManager.LoggedUser.Accounts)
            {
                cmbAccountBudget.Items.Add(account.Name);
            }

            if (cmbAccountBudget.Items.Count > 0)
            {
                cmbAccountBudget.SelectedIndex = 0;
            }
            txtlimitAmount.Text = _currentBudget.AmountLimit.ToString("F2");
            pnlEditBudget.Visible = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentBudget != null)
            {
                var confirmation = MessageBox.Show("Are you sure you want to delete this budget?", "Delete Budget", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    App.State.UserManager.LoggedUser.Budgets.Remove(_currentBudget);

                    MessageBox.Show("Budget deleted successfully.");

                    pnlEditBudget.Visible = false;
                    LoadBudgets();
                }
            }
            else
            {
                MessageBox.Show("No budget selected for deletion.");
            }
        }
    }
}
