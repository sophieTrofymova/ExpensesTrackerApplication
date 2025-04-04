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




    public partial class Sanbox : Form
    {
        private User testUser;
        private List<Transaction> transactions = new List<Transaction>();
        private List<Budget> budgets = new List<Budget>();
        public Sanbox()
        {
            InitializeComponent();
            this.Load += Sanbox_Load;
            InitializeTestData();
        }
        private void Sanbox_Load(object sender, EventArgs e)
        {
            InitializeTestData();
            DisplayAccountSummary();
            PopulateIncomeCategories();
            PopulateExpenseCategories();
            PopulateAccountsToAddIncome();
            PopulateAccountsToAddExpense();
            PopulateCurrencyDropdown();
            DisplayAccountsInListView();
            DisplayBudgetProgress();
            PopulateAccountDropdownForBudget();
            DisplayBudgetsInListView();
            PopulateCategoriesDropdownForBudget();


        }

        private void InitializeTestData()
        {

            testUser = new User("JohnDoe", "password1", "john.doe@email.com", "John Doe");

            Account bankAccount = new Account("Bank", 1500.00m, CurrencyType.EUR);
            Account wallet = new Account("Wallet", 200.50m, CurrencyType.EUR);

            testUser.AddAccount(bankAccount);
            testUser.AddAccount(wallet);

            Transaction transaction1 = new Transaction(Guid.NewGuid())
            {
                Type = TransactionType.Expense,
                Amount = 50.00m,
                CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Food & Dining"),
                EffectDate = DateTime.Now,
                Description = "Lunch at a restaurant"
            };

            transactions.Add(new Transaction(bankAccount.ID)
            {
                Type = TransactionType.Income,
                Amount = 2000.00m,
                CategoryInfo = CategoryInfo.IncomeCategories.First(c => c.Description == "Salary"),
                ReceiverAccount = bankAccount.ID,
                EffectDate = DateTime.Now.AddDays(-5),
                Description = "Monthly salary from employer"
            });

            transactions.Add(new Transaction(wallet.ID)
            {
                Type = TransactionType.Expense,
                Amount = 50.00m,
                CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Food & Dining"),
                SenderAccount = wallet.ID,
                EffectDate = DateTime.Now.AddDays(-2),
                Description = "Lunch at a restaurant"
            });


            transactions.Add(new Transaction(bankAccount.ID)
            {
                Type = TransactionType.Transfer,
                Amount = 200.00m,
                CategoryInfo = CategoryInfo.ExpenseCategories.First(c => c.Description == "Transfer"),
                SenderAccount = bankAccount.ID,
                ReceiverAccount = wallet.ID,
                EffectDate = DateTime.Now,
                Description = "Transferred money from bank to wallet"
            });

            CategoryInfo entertainmentCategory = CategoryInfo.ExpenseCategories.First(c => c.Description == "Entertainment");
            budgets.Add(new Budget(wallet.ID, entertainmentCategory, 100.00m)); 
        }
        
        private void PopulateIncomeCategories()
        {

            dropDownCategoryIncome.Items.Clear();
            foreach (var category in CategoryInfo.IncomeCategories)
            {
                dropDownCategoryIncome.Items.Add(category.Description);
            }
        }
        private void PopulateExpenseCategories()
        {
            //var expenseCategories = CategoryInfo.GetDefaultCategories()
            //                                    .Where(c => c.Type == CategoryType.Expense)
            //                                    .ToList();

            //dropDownCategoryExpense.Items.Clear();
            //foreach (var category in expenseCategories)
            //{
            //    dropDownCategoryExpense.Items.Add(category.Description);
            //}



            dropDownCategoryExpense.Items.Clear();
            foreach (var category in CategoryInfo.ExpenseCategories)
            {
                dropDownCategoryExpense.Items.Add(category);
            }
            dropDownCategoryExpense.DisplayMember = "Description";
            dropDownCategoryExpense.ValueMember = "Description";
        }

        private void PopulateAccountsToAddIncome()
        {
            if (testUser?.Accounts == null || testUser.Accounts.Count == 0)
            {
                MessageBox.Show("No accounts found. Please add an account first.");
                return;
            }

            dropDownAccountAddIncome.Items.Clear();

            foreach (var account in testUser.Accounts)
            {
                dropDownAccountAddIncome.Items.Add(account.Name);
            }

            if (dropDownAccountAddIncome.Items.Count > 0)
            {
                dropDownAccountAddIncome.SelectedIndex = 0;
            }
        }

        private void PopulateAccountsToAddExpense()
        {
            if (testUser?.Accounts == null || testUser.Accounts.Count == 0)
            {
                MessageBox.Show("No accounts found. Please add an account first.");
                return;
            }

            dropDownAccountAddExpense.Items.Clear();

            foreach (var account in testUser.Accounts)
            {
                dropDownAccountAddExpense.Items.Add(account.Name);
            }

            if (dropDownAccountAddExpense.Items.Count > 0)
            {
                dropDownAccountAddExpense.SelectedIndex = 0;
            }
        }
        private void PopulateCurrencyDropdown()
        {
            dropDownCurrencyAddAccount.Items.Clear();
            foreach (var currency in Enum.GetValues(typeof(CurrencyType)))
            {
                dropDownCurrencyAddAccount.Items.Add(currency.ToString());
            }
            dropDownCurrencyAddAccount.SelectedIndex = 0;
        }
        private void PopulateAccountDropdownForBudget()
        {
            dropDownAccountBudget.Items.Clear();
            foreach (var account in testUser.Accounts)
            {
                dropDownAccountBudget.Items.Add(account.Name);
            }
            if (dropDownAccountBudget.Items.Count > 0)
            {
                dropDownAccountBudget.SelectedIndex = 0;
            }
        }
        private void PopulateCategoriesDropdownForBudget()
        {


            dropDownCategoryBudget.Items.Clear();
            foreach (var category in CategoryInfo.ExpenseCategories)
            {
                dropDownCategoryBudget.Items.Add(category);
            }
            dropDownCategoryBudget.DisplayMember = "Description";
            dropDownCategoryBudget.ValueMember = "Description";
        }
        private void DisplayBudgetsInListView()
        {
            listViewBudgets.Items.Clear();

            foreach (var budget in testUser.Budgets)
            {
                string categoryString = budget.CategoryInfo.Description.ToString();

                ListViewItem item = new ListViewItem(categoryString);
                item.SubItems.Add($"{budget.GetUsagePercentage():F1}%");

                listViewBudgets.Items.Add(item);
            }
        }

        private void DisplayBudgetProgress()
        {
            tblBudgetProgress.Controls.Clear();
            tblBudgetProgress.RowStyles.Clear();
            tblBudgetProgress.RowCount = 1;

            foreach (var budget in testUser.Budgets)
            {
                Label lblCategory = new Label();
                lblCategory.Text = budget.CategoryInfo.Description.ToString();
                lblCategory.ForeColor = Color.White;
                lblCategory.AutoSize = true;

                ProgressBar progressBar = new ProgressBar();
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = (int)budget.GetUsagePercentage();
                progressBar.Width = 200;

                tblBudgetProgress.Controls.Add(lblCategory, 0, tblBudgetProgress.RowCount - 1);
                tblBudgetProgress.Controls.Add(progressBar, 1, tblBudgetProgress.RowCount - 1);

                tblBudgetProgress.RowCount++;
            }
        }

        private void SetBudget()
        {
            var selectedCategoryInfo = dropDownCategoryBudget.SelectedItem as CategoryInfo;
            if (selectedCategoryInfo == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            string accountName = dropDownAccountBudget.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(accountName))
            {
                MessageBox.Show("Please select an account.");
                return;
            }

            var selectedAccount = testUser.Accounts.FirstOrDefault(a => a.Name == accountName);
            if (selectedAccount == null)
            {
                MessageBox.Show("Selected account not found.");
                return;
            }

            if (!decimal.TryParse(txtBudgetAmount.Text, out decimal limit) || limit <= 0)
            {
                MessageBox.Show("Invalid budget amount.");
                return;
            }

            Budget existingBudget = testUser.Budgets.FirstOrDefault(b =>
                                              b.CategoryInfo.Description == selectedCategoryInfo.Description &&
                                              b.AccountID == selectedAccount.ID);

            if (existingBudget != null)
            {
                existingBudget.AmountLimit = limit;
                MessageBox.Show($"Budget updated for {selectedCategoryInfo.Description} on account {selectedAccount.Name}: €{limit}");
            }
            else
            {
                Budget newBudget = new Budget(selectedAccount.ID, selectedCategoryInfo, limit);
                testUser.Budgets.Add(newBudget);
                MessageBox.Show($"New budget set for {selectedCategoryInfo.Description} on account {selectedAccount.Name}: €{limit}");
            }
            txtBudgetAmount.Text = "";
            dropDownCategoryBudget.SelectedIndex = -1;
            dropDownAccountBudget.SelectedIndex = -1;
            DisplayBudgetProgress();
            DisplayBudgetsInListView();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabDashboard_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void tabAccounts_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddIncome_Click_1(object sender, EventArgs e)
        {
            string selectedCategoryDescription = dropDownCategoryIncome.SelectedItem.ToString();

            var selectedCategory = CategoryInfo.IncomeCategories
                                                 .FirstOrDefault(c => c.Description == selectedCategoryDescription);
            string selectedAccountName = dropDownAccountAddIncome.SelectedItem?.ToString();

            var selectedAccount = testUser.Accounts.FirstOrDefault(a => a.Name == selectedAccountName);

            if (selectedAccount != null)
            {
                decimal amount = decimal.Parse(txtValueAddIncome.Text);

                Transaction newTransaction = new Transaction(creatorAccount: testUser.Accounts.First().ID)
                {
                    Type = TransactionType.Income,
                    Amount = amount,
                    CategoryInfo = selectedCategory,
                    ReceiverAccount = selectedAccount.ID,
                    EffectDate = DateTime.Now
                };

                // Update account balance
                selectedAccount.Balance += amount;

                MessageBox.Show($"New income has been added to account {selectedAccount.Name}: €{newTransaction.Amount}. New Balance: €{selectedAccount.Balance}");

                // Clear input fields
                txtValueAddIncome.Text = "";
                dropDownCategoryIncome.SelectedIndex = -1;
                dropDownAccountAddIncome.SelectedIndex = -1;
            }
        }
        private void DisplayAccountSummary()
        {
            tblAccountsSummary2.Visible = true;

            tblAccountsSummary2.Controls.Clear();
            tblAccountsSummary2.RowStyles.Clear();
            tblAccountsSummary2.RowCount = 0;

            tblAccountsSummary2.ColumnCount = 2;
            tblAccountsSummary2.ColumnStyles.Clear();
            tblAccountsSummary2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F)); // Name (70%)
            tblAccountsSummary2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Balance (30%)

            foreach (var account in testUser.Accounts)
            {
                tblAccountsSummary2.RowCount++; 
                tblAccountsSummary2.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // Account Name Label
                Label lblAccountName = new Label
                {
                    Text = account.Name,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = true
                };

                // Account Balance Label
                Label lblAccountBalance = new Label
                {
                    Text = $"{account.Balance:C}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight
                };

                // Add labels to TableLayoutPanel
                tblAccountsSummary2.Controls.Add(lblAccountName, 0, tblAccountsSummary.RowCount - 1);
                tblAccountsSummary2.Controls.Add(lblAccountBalance, 1, tblAccountsSummary.RowCount - 1);
            }
        }
        private void DisplayAccountsInListView()
        {
            listViewAccounts.Items.Clear();

            foreach (var account in testUser.Accounts)
            {
                ListViewItem item = new ListViewItem(account.Name);
                item.SubItems.Add(account.Balance.ToString("C"));
                item.SubItems.Add(account.Currency.ToString()); 

                listViewAccounts.Items.Add(item); 
            }
        }

        private void AddAccount()
        {
            string accountName = txtBoxNameAddAccount.Text.Trim();
            string currencyString = dropDownCurrencyAddAccount.SelectedItem?.ToString();
            string balanceText = txtBoxAmountAddAccount.Text.Trim();

            if (string.IsNullOrEmpty(accountName) || string.IsNullOrEmpty(currencyString) || string.IsNullOrEmpty(balanceText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(balanceText, out decimal initialBalance))
            {
                MessageBox.Show("Invalid balance amount.");
                return;
            }

            if (!Enum.TryParse(currencyString, out CurrencyType selectedCurrency))
            {
                MessageBox.Show("Invalid currency selected.");
                return;
            }

            Account newAccount = new Account(accountName, initialBalance, selectedCurrency);
            testUser.AddAccount(newAccount);

            MessageBox.Show($"Account '{newAccount.Name}' added successfully!");
            DisplayAccountSummary();
            DisplayAccountsInListView();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void txtBalance_Click(object sender, EventArgs e)
        {

        }

        private void dropDownCategoryBudget_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateABudget_Click(object sender, EventArgs e)
        {
            SetBudget();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string selectedCategoryDescription = dropDownCategoryExpense.SelectedItem.ToString();

            var selectedCategory = CategoryInfo.ExpenseCategories
                                                 .FirstOrDefault(c => c.Description == selectedCategoryDescription);
            string selectedAccountName = dropDownAccountAddExpense.SelectedItem?.ToString();

            var selectedAccount = testUser.Accounts.FirstOrDefault(a => a.Name == selectedAccountName);

            if (selectedAccount != null)
            {
                decimal amount = decimal.Parse(txtValueAddExpense.Text);

                var budget = testUser.Budgets.FirstOrDefault(b => b.CategoryDescription == selectedCategoryDescription &&
                                                          b.Month.Month == DateTime.Now.Month &&
                                                          b.Month.Year == DateTime.Now.Year);

                if (budget != null)
                {
                    budget.Spent += amount;  

                    if (budget.NeedsWarning())
                    {
                        MessageBox.Show($"Warning! You have spent 70% of your {selectedCategoryDescription} budget within the first half of the month.");
                    }
                }
                Transaction newTransaction = new Transaction(creatorAccount: testUser.Accounts.First().ID)
                {
                    Type = TransactionType.Expense,
                    Amount = amount,
                    CategoryInfo = selectedCategory,
                    ReceiverAccount = selectedAccount.ID,
                    EffectDate = DateTime.Now
                };

                selectedAccount.Balance -= amount;

                MessageBox.Show($"New expense has been added to account {selectedAccount.Name}: €{newTransaction.Amount}. New Balance: €{selectedAccount.Balance}");

                txtValueAddExpense.Text = "";
                dropDownCategoryExpense.SelectedIndex = -1;
                dropDownAccountAddExpense.SelectedIndex = -1;
            }
        }

        private void dropDownCategoryIncome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void bTestNotification_Click(object sender, EventArgs e)
        {
            ShowNotification("Test Notification", "Test Message");

            ShowNotification("Test Notification", "Test Message");
            ShowNotification("Test Notification", "Test Message");
        }

    }
}
