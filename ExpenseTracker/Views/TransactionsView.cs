//using ExpenseTracker.Controls;

//namespace ExpenseTracker.Views
//{
//    public class TransactionsView : ElementView
//    {
//        public TransactionsView(ElementContainer container, string name = "Transactions") : base(name, container)
//        {
//            this.NumRows = 8;
//            this.NumCols = 9;

//        }


//        public override void Build()
//        {
//            ClearElements();

//            var filter = new Element();
//            filter.GroupBox.Text = "Filter";
//            filter.Collumn = 1;
//            filter.Row = 1;

//            filter.Cols = 2;
//            filter.Rows = 6;
//            filter.AllowDrag = false;

//            var transactions = new Element();
//            transactions.GroupBox.Text = "Transactions";
//            transactions.Collumn = 3;
//            transactions.Row = 1;

//            transactions.Cols = 5;
//            transactions.Rows = 6;
//            transactions.AllowDrag = false;

//            AddElements(new List<Element> { filter, transactions });
//        }
//    }
//}

using ExpenseTracker.Controls;
using System;
using System.Globalization;
using System.Linq;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views
{
    public class TransactionsView : ElementView
    {

        private ListView transactionListView;
        public TransactionsView(ElementContainer container, string name = "Transactions") : base(name, container)
        {
            this.NumRows = 12;
            this.NumCols = 12;
        }
        public override void Build()
        {
            

        var filter = new Element();
            filter.GroupBox.Text = "Filter by Month";
            filter.Collumn = 1;
            filter.Row = 1;
            filter.Cols = 2;
            filter.Rows = 3;
            filter.AllowDrag = false;

            var monthDropDown = new WF.ComboBox
            {
                Name = "MonthDropDown",
                DropDownStyle = WF.ComboBoxStyle.DropDownList,
                Items = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
                //SelectedIndex = DateTime.Now.Month - 1
            };
            int centerX = (filter.GroupBox.Width - monthDropDown.Width) / 2;
            monthDropDown.Location = new System.Drawing.Point(centerX, 30); 
            monthDropDown.SelectedIndexChanged += MonthDropDown_SelectedIndexChanged;
            filter.GroupBox.Controls.Add(monthDropDown);

            var incomeGroupBox = new Element();
            incomeGroupBox.GroupBox.Text = "Add Income";
            incomeGroupBox.Collumn = 1;
            incomeGroupBox.Row = 4;
            incomeGroupBox.Cols = 6;
            incomeGroupBox.Rows = 4;
            incomeGroupBox.AllowDrag = false;

            var lblCategoryIncome = new WF.Label
            {
                Text = "Category:",
                Location = new System.Drawing.Point(30, 50),
                AutoSize = true
            };

            // ComboBox for Category
            var dropDownCategoryIncome = new WF.ComboBox
            {
                Name = "DropDownCategoryIncome",
                Location = new System.Drawing.Point(180, 50),
                Width = 150,
                BackColor = System.Drawing.Color.White
            };
            dropDownCategoryIncome.Items.AddRange(CategoryInfo.IncomeCategories.Select(c => c.Description).ToArray());

            // Label for Account
            var lblAccountIncome = new WF.Label
            {
                Text = "Account:",
                Location = new System.Drawing.Point(30, 120),
                AutoSize = true
            };

            // ComboBox for Account
            var dropDownAccountIncome = new WF.ComboBox
            {
                Name = "DropDownAccountIncome",
                Location = new System.Drawing.Point(180, 120),
                Width = 150,
                BackColor = System.Drawing.Color.White
            };
            PopulateAccountsToAddIncome(dropDownAccountIncome);

            // Label for Amount
            var lblValueIncome = new WF.Label
            {
                Text = "Amount (€):",
                Location = new System.Drawing.Point(30, 190),
                AutoSize = true
            };

            // TextBox for Value
            var txtValueAddIncome = new WF.TextBox
            {
                Location = new System.Drawing.Point(200, 190),
                Width = 100,
                BackColor = System.Drawing.Color.White
            };

            // Button to Add Income
            var btnAddIncome = new WF.Button
            {
                Text = "Add Income",
                Location = new System.Drawing.Point(480, 220),
                BackColor = System.Drawing.Color.LightGreen,
                Size = new System.Drawing.Size(150, 50)
            };
            btnAddIncome.Click += (sender, e) => btnAddIncome_Click(sender, e, dropDownCategoryIncome, txtValueAddIncome, dropDownAccountIncome);


            incomeGroupBox.GroupBox.Controls.Add(lblCategoryIncome);
            incomeGroupBox.GroupBox.Controls.Add(dropDownCategoryIncome);
            incomeGroupBox.GroupBox.Controls.Add(lblAccountIncome);
            incomeGroupBox.GroupBox.Controls.Add(dropDownAccountIncome);
            incomeGroupBox.GroupBox.Controls.Add(lblValueIncome);
            incomeGroupBox.GroupBox.Controls.Add(txtValueAddIncome);
            incomeGroupBox.GroupBox.Controls.Add(btnAddIncome);

            var expenseGroupBox = new Element();
            expenseGroupBox.GroupBox.Text = "Add Expense";
            expenseGroupBox.Collumn = 1;
            expenseGroupBox.Row = 8;
            expenseGroupBox.Cols = 6;
            expenseGroupBox.Rows = 4;
            expenseGroupBox.AllowDrag = false;

            // Label for Category
            var lblCategoryExpense = new WF.Label
            {
                Text = "Category:",
                Location = new System.Drawing.Point(30, 50),
                AutoSize = true
            };

            // ComboBox for Category
            var dropDownCategoryExpense = new WF.ComboBox
            {
                Name = "DropDownCategoryExpense",
                Location = new System.Drawing.Point(180, 50),
                Width = 180,
                BackColor = System.Drawing.Color.White
            };
            dropDownCategoryExpense.Items.AddRange(CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray());

            // Label for Account
            var lblAccountExpense = new WF.Label
            {
                Text = "Account:",
                Location = new System.Drawing.Point(30, 120),
                AutoSize = true
            };

            // ComboBox for Account
            var dropDownAccountExpense = new WF.ComboBox
            {
                Name = "DropDownAccountExpense",
                Location = new System.Drawing.Point(180, 120),
                Width = 180,
                BackColor = System.Drawing.Color.White
            };
            PopulateAccountsToAddExpense(dropDownAccountExpense);

            // Label for Amount
            var lblAmountExpense = new WF.Label
            {
                Text = "Amount:",
                Location = new System.Drawing.Point(30, 190),
                AutoSize = true
            };

            // TextBox for Value
            var txtValueAddExpense = new WF.TextBox
            {
                Location = new System.Drawing.Point(200, 190),
                Width = 100,
                BackColor = System.Drawing.Color.White
            };

            // Button to Add Expense
            var btnAddExpense = new WF.Button
            {
                Text = "Add Expense",
                Location = new System.Drawing.Point(480, 220),
                BackColor = System.Drawing.Color.Red,
                Size = new System.Drawing.Size(150, 50)
            };
            btnAddExpense.Click += (sender, e) => btnAddExpense_Click(sender, e, dropDownCategoryExpense, txtValueAddExpense, dropDownAccountExpense);

            // Add to GroupBox
            expenseGroupBox.GroupBox.Controls.Add(lblCategoryExpense);
            expenseGroupBox.GroupBox.Controls.Add(dropDownCategoryExpense);
            expenseGroupBox.GroupBox.Controls.Add(lblAccountExpense);
            expenseGroupBox.GroupBox.Controls.Add(dropDownAccountExpense);
            expenseGroupBox.GroupBox.Controls.Add(lblAmountExpense);
            expenseGroupBox.GroupBox.Controls.Add(txtValueAddExpense);
            expenseGroupBox.GroupBox.Controls.Add(btnAddExpense);


            string selectedMonthName = monthDropDown.SelectedItem?.ToString() ?? "Current Month";

            var transactionsGroupBox = new Element();
            transactionsGroupBox.GroupBox.Text = $"Transactions for {selectedMonthName}";
            transactionsGroupBox.Collumn = 7;
            transactionsGroupBox.Row = 1;
            transactionsGroupBox.Cols = 6;
            transactionsGroupBox.Rows = 10;
            transactionsGroupBox.AllowDrag = false;

            transactionListView = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Location = new System.Drawing.Point(10, 25),
                Size = new System.Drawing.Size(550, 250),
                Dock = DockStyle.Fill,
                Columns =
                {
                    new WF.ColumnHeader { Text = "Date", Width = 120 },
                    new WF.ColumnHeader { Text = "Category", Width = 180 },
                    new WF.ColumnHeader { Text = "Amount", Width = 100 }
                }
            };

            transactionsGroupBox.GroupBox.Controls.Add(transactionListView);

            LoadTransactions(transactionListView, selectedMonthName);

            AddElements(new List<Element> { filter, incomeGroupBox, expenseGroupBox, transactionsGroupBox });



        }

        
        private void MonthDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMonth = ((WF.ComboBox)sender).SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedMonth))
            {
                LoadTransactions(null, selectedMonth);
            }
            else
            {
                MessageBox.Show("Please select a month.");
            }
        }

        private void LoadTransactions(ListView transactionListView, string selectedMonthName)
        {
            var transactionManager = new TransactionManager();
            transactionManager.DisplayTransactions(transactionListView, selectedMonthName);
        }

        private void PopulateAccountsToAddIncome(WF.ComboBox dropDownAccountIncome)
        {
            if (MainForm.AppState.currentUser?.Accounts == null || MainForm.AppState.currentUser.Accounts.Count == 0)
            {
                MessageBox.Show("No accounts found. Please add an account first.");
                return;
            }

            dropDownAccountIncome.Items.Clear();

            foreach (var account in MainForm.AppState.currentUser.Accounts)
            {
                dropDownAccountIncome.Items.Add(account.Name);
            }

            if (dropDownAccountIncome.Items.Count > 0)
            {
                dropDownAccountIncome.SelectedIndex = 0;
            }
        }

        private void PopulateAccountsToAddExpense(WF.ComboBox dropDownAccountExpense)
        {
            if (MainForm.AppState.currentUser?.Accounts == null || MainForm.AppState.currentUser.Accounts.Count == 0)
            {
                MessageBox.Show("No accounts found. Please add an account first.");
                return;
            }

            dropDownAccountExpense.Items.Clear();

            foreach (var account in MainForm.AppState.currentUser.Accounts)
            {
                dropDownAccountExpense.Items.Add(account.Name);
            }

            if (dropDownAccountExpense.Items.Count > 0)
            {
                dropDownAccountExpense.SelectedIndex = 0;
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e, WF.ComboBox dropDownCategoryIncome, WF.TextBox txtValueAddIncome, WF.ComboBox dropDownAccountIncome)
        {
            if (dropDownCategoryIncome.SelectedItem != null)
            {
                string selectedCategoryDescription = dropDownCategoryIncome.SelectedItem.ToString();
                var selectedCategory = CategoryInfo.IncomeCategories
                                                    .FirstOrDefault(c => c.Description == selectedCategoryDescription);

                if (dropDownAccountIncome.SelectedItem != null)
                {
                    string selectedAccountName = dropDownAccountIncome.SelectedItem.ToString();
                    var selectedAccount = MainForm.AppState.currentUser.Accounts.FirstOrDefault(a => a.Name == selectedAccountName);

                    if (selectedAccount != null)
                    {
                        decimal amount;
                        if (decimal.TryParse(txtValueAddIncome.Text, out amount))
                        {
                            Transaction newTransaction = new Transaction(creatorAccount: MainForm.AppState.currentUser.Accounts.First().ID)
                            {
                                Type = TransactionType.Income,
                                Amount = amount,
                                CategoryInfo = selectedCategory,
                                ReceiverAccount = selectedAccount.ID,
                                EffectDate = DateTime.Now
                            };

                            selectedAccount.Balance += amount;

                            MessageBox.Show($"New income added: €{newTransaction.Amount}. New Balance: €{selectedAccount.Balance}");

                            txtValueAddIncome.Text = "";
                            dropDownCategoryIncome.SelectedIndex = -1;
                            dropDownAccountIncome.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid amount.");
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
                MessageBox.Show("Please select a category.");
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e, WF.ComboBox dropDownCategoryExpense, WF.TextBox txtValueAddExpense, WF.ComboBox dropDownAccountExpense)
        {
            if (dropDownCategoryExpense.SelectedItem != null)
            {
                string selectedCategoryDescription = dropDownCategoryExpense.SelectedItem.ToString();
                var selectedCategory = CategoryInfo.ExpenseCategories
                                                    .FirstOrDefault(c => c.Description == selectedCategoryDescription);

                if (dropDownAccountExpense.SelectedItem != null)
                {
                    string selectedAccountName = dropDownAccountExpense.SelectedItem.ToString();
                    var selectedAccount = MainForm.AppState.currentUser.Accounts.FirstOrDefault(a => a.Name == selectedAccountName);

                    if (selectedAccount != null)
                    {
                        decimal amount;
                        if (decimal.TryParse(txtValueAddExpense.Text, out amount))
                        {
                            Transaction newTransaction = new Transaction(creatorAccount: MainForm.AppState.currentUser.Accounts.First().ID)
                            {
                                Type = TransactionType.Expense,  
                                Amount = amount,
                                CategoryInfo = selectedCategory,
                                ReceiverAccount = selectedAccount.ID,
                                EffectDate = DateTime.Now
                            };

                            selectedAccount.Balance -= amount;

                            MessageBox.Show($"New expense added: €{newTransaction.Amount}. New Balance: €{selectedAccount.Balance}");

                            txtValueAddExpense.Text = "";
                            dropDownCategoryExpense.SelectedIndex = -1;
                            dropDownAccountExpense.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid amount.");
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
                MessageBox.Show("Please select a category.");
            }
        }

     
    }
    }


