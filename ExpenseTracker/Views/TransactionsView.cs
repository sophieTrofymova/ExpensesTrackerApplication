

using ExpenseTracker.Controls;
using ExpenseTracker.Elements;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views {
    public class TransactionsView : ElementView {

        private ListView transactionListView;
        public TransactionsView(ElementContainer container, string name = "Transactions") : base(name, container) {
            this.NumRows = 10;
            this.NumCols = 20;

            Padding = new System.Windows.Forms.Padding(25);
        }

        public override void Build() {

            var user = App.State.UserManager.LoggedUser;

            this.ClearElements();
            var transactionsElement = new TransactionsElement() {
                Title = "Transactions View",
                Col = 0,
                Cols = 20,
                Row = 0,
                Rows = 10,
                AllowDrag = false
            };

            AddElements(new List<Element> { transactionsElement });
            transactionsElement.Init();

        }

        public  void Build2() {


            var filter = new FilterTransactionsElement() {
                Title = "Filter Transactions",
                Col = 1,
                Cols = 20,
                Row = 1,
                Rows = 3,
                AllowDrag = false
            };

            filter.monthDropDown.SelectedIndexChanged += (object sender, EventArgs e) => {
                var selectedMonth = ((WF.ComboBox)sender).SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedMonth)) {
                    LoadTransactions(transactionListView, selectedMonth);
                }
                else {
                    MessageBox.Show("Please select a month.");
                }
            };




            var incomeGroupBox = new Element() {
                Title = "Add Income",
                Col = 1,
                Cols = 6,
                Row = 4,
                Rows = 4,
                AllowDrag = false
            };

            var lblCategoryIncome = new WF.Label {
                Text = "Category:",
                Location = new System.Drawing.Point(30, 50),
                AutoSize = true
            };

            // ComboBox for Category
            var dropDownCategoryIncome = new WF.ComboBox {
                Name = "DropDownCategoryIncome",
                Location = new System.Drawing.Point(180, 50),
                Width = 150,
                BackColor = System.Drawing.Color.White
            };
            dropDownCategoryIncome.Items.AddRange(CategoryInfo.IncomeCategories.Select(c => c.Description).ToArray());

            // Label for Account
            var lblAccountIncome = new WF.Label {
                Text = "Account:",
                Location = new System.Drawing.Point(30, 120),
                AutoSize = true
            };

            // ComboBox for Account
            var dropDownAccountIncome = new WF.ComboBox {
                Name = "DropDownAccountIncome",
                Location = new System.Drawing.Point(180, 120),
                Width = 150,
                BackColor = System.Drawing.Color.White
            };
            PopulateAccountsToAddIncome(dropDownAccountIncome);

            // Label for Amount
            var lblValueIncome = new WF.Label {
                Text = "Amount (€):",
                Location = new System.Drawing.Point(30, 190),
                AutoSize = true
            };

            // TextBox for Value
            var txtValueAddIncome = new WF.TextBox {
                Location = new System.Drawing.Point(200, 190),
                Width = 100,
                BackColor = System.Drawing.Color.White
            };

            // Button to Add Income
            var btnAddIncome = new WF.Button {
                Text = "Add Income",
                Location = new System.Drawing.Point(480, 220),
                BackColor = System.Drawing.Color.LightGreen,
                Size = new System.Drawing.Size(150, 50)
            };
            btnAddIncome.Click += (sender, e) => btnAddIncome_Click(sender, e, dropDownCategoryIncome, txtValueAddIncome, dropDownAccountIncome);


            incomeGroupBox.ThemedGroupBox.Controls.Add(lblCategoryIncome);
            incomeGroupBox.ThemedGroupBox.Controls.Add(dropDownCategoryIncome);
            incomeGroupBox.ThemedGroupBox.Controls.Add(lblAccountIncome);
            incomeGroupBox.ThemedGroupBox.Controls.Add(dropDownAccountIncome);
            incomeGroupBox.ThemedGroupBox.Controls.Add(lblValueIncome);
            incomeGroupBox.ThemedGroupBox.Controls.Add(txtValueAddIncome);
            incomeGroupBox.ThemedGroupBox.Controls.Add(btnAddIncome);

            var expenseGroupBox = new Element();
            expenseGroupBox.ThemedGroupBox.Text = "Add Expense";
            expenseGroupBox.Col = 1;
            expenseGroupBox.Row = 8;
            expenseGroupBox.Cols = 6;
            expenseGroupBox.Rows = 4;
            expenseGroupBox.AllowDrag = false;

            // Label for Category
            var lblCategoryExpense = new WF.Label {
                Text = "Category:",
                Location = new System.Drawing.Point(30, 50),
                AutoSize = true
            };

            // ComboBox for Category
            var dropDownCategoryExpense = new WF.ComboBox {
                Name = "DropDownCategoryExpense",
                Location = new System.Drawing.Point(180, 50),
                Width = 180,
                BackColor = System.Drawing.Color.White
            };
            dropDownCategoryExpense.Items.AddRange(CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray());

            // Label for Account
            var lblAccountExpense = new WF.Label {
                Text = "Account:",
                Location = new System.Drawing.Point(30, 120),
                AutoSize = true
            };

            // ComboBox for Account
            var dropDownAccountExpense = new WF.ComboBox {
                Name = "DropDownAccountExpense",
                Location = new System.Drawing.Point(180, 120),
                Width = 180,
                BackColor = System.Drawing.Color.White
            };
            PopulateAccountsToAddExpense(dropDownAccountExpense);

            // Label for Amount
            var lblAmountExpense = new WF.Label {
                Text = "Amount:",
                Location = new System.Drawing.Point(30, 190),
                AutoSize = true
            };

            // TextBox for Value
            var txtValueAddExpense = new WF.TextBox {
                Location = new System.Drawing.Point(200, 190),
                Width = 100,
                BackColor = System.Drawing.Color.White
            };

            // Button to Add Expense
            var btnAddExpense = new WF.Button {
                Text = "Add Expense",
                Location = new System.Drawing.Point(480, 220),
                BackColor = System.Drawing.Color.Red,
                Size = new System.Drawing.Size(150, 50)
            };
            btnAddExpense.Click += (sender, e) => btnAddExpense_Click(sender, e, dropDownCategoryExpense, txtValueAddExpense, dropDownAccountExpense);

            // Add to ThemedGroupBox
            expenseGroupBox.ThemedGroupBox.Controls.Add(lblCategoryExpense);
            expenseGroupBox.ThemedGroupBox.Controls.Add(dropDownCategoryExpense);
            expenseGroupBox.ThemedGroupBox.Controls.Add(lblAccountExpense);
            expenseGroupBox.ThemedGroupBox.Controls.Add(dropDownAccountExpense);
            expenseGroupBox.ThemedGroupBox.Controls.Add(lblAmountExpense);
            expenseGroupBox.ThemedGroupBox.Controls.Add(txtValueAddExpense);
            expenseGroupBox.ThemedGroupBox.Controls.Add(btnAddExpense);


            string selectedMonthName = filter.monthDropDown.SelectedItem?.ToString() ?? "Current Month";

            var transactionsGroupBox = new Element();
            transactionsGroupBox.ThemedGroupBox.Text = $"Transactions for {selectedMonthName}";
            transactionsGroupBox.Col = 7;
            transactionsGroupBox.Row = 4;
            transactionsGroupBox.Cols = 14;
            transactionsGroupBox.Rows = 8;
            transactionsGroupBox.AllowDrag = false;

            transactionListView = new ListView {
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

            transactionsGroupBox.ThemedGroupBox.Controls.Add(transactionListView);

            LoadTransactions(transactionListView, selectedMonthName);

            AddElements(new List<Element> { filter, incomeGroupBox, expenseGroupBox, transactionsGroupBox });



        }



        private void LoadTransactions(ListView transactionListView, string selectedMonthName) {
            var transactionManager = new TransactionManager();
            transactionManager.Transactions = App.State.UserManager.LoggedUser.Transactions;
            transactionManager.DisplayTransactions(transactionListView, selectedMonthName);
        }

        private void PopulateAccountsToAddIncome(WF.ComboBox dropDownAccountIncome) {
            if (App.State.UserManager.LoggedUser?.Accounts == null || App.State.UserManager.LoggedUser.Accounts.Count == 0) {
                MessageBox.Show("No accounts found. Please add an account first.");
                return;
            }

            dropDownAccountIncome.Items.Clear();

            foreach (var account in App.State.UserManager.LoggedUser.Accounts) {
                dropDownAccountIncome.Items.Add(account.Name);
            }

            if (dropDownAccountIncome.Items.Count > 0) {
                dropDownAccountIncome.SelectedIndex = 0;
            }
        }

        private void PopulateAccountsToAddExpense(WF.ComboBox dropDownAccountExpense) {
            if (App.State.UserManager.LoggedUser?.Accounts == null || App.State.UserManager.LoggedUser.Accounts.Count == 0) {
                MessageBox.Show("No accounts found. Please add an account first.");
                return;
            }

            dropDownAccountExpense.Items.Clear();

            foreach (var account in App.State.UserManager.LoggedUser.Accounts) {
                dropDownAccountExpense.Items.Add(account.Name);
            }

            if (dropDownAccountExpense.Items.Count > 0) {
                dropDownAccountExpense.SelectedIndex = 0;
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e, WF.ComboBox dropDownCategoryIncome, WF.TextBox txtValueAddIncome, WF.ComboBox dropDownAccountIncome) {
            if (dropDownCategoryIncome.SelectedItem != null) {
                string selectedCategoryDescription = dropDownCategoryIncome.SelectedItem.ToString();
                var selectedCategory = CategoryInfo.IncomeCategories
                                                    .FirstOrDefault(c => c.Description == selectedCategoryDescription);

                if (dropDownAccountIncome.SelectedItem != null) {
                    string selectedAccountName = dropDownAccountIncome.SelectedItem.ToString();
                    var selectedAccount = App.State.UserManager.LoggedUser.Accounts.FirstOrDefault(a => a.Name == selectedAccountName);

                    if (selectedAccount != null) {
                        decimal amount;
                        if (decimal.TryParse(txtValueAddIncome.Text, out amount)) {
                            Transaction newTransaction = new Transaction(creatorAccount: App.State.UserManager.LoggedUser.Accounts.First().ID) {
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
                        else {
                            MessageBox.Show("Please enter a valid amount.");
                        }
                    }
                    else {
                        MessageBox.Show("Selected account is not valid.");
                    }
                }
                else {
                    MessageBox.Show("Please select an account.");
                }
            }
            else {
                MessageBox.Show("Please select a category.");
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e, WF.ComboBox dropDownCategoryExpense, WF.TextBox txtValueAddExpense, WF.ComboBox dropDownAccountExpense) {
            if (dropDownCategoryExpense.SelectedItem != null) {
                string selectedCategoryDescription = dropDownCategoryExpense.SelectedItem.ToString();
                var selectedCategory = CategoryInfo.ExpenseCategories
                                                    .FirstOrDefault(c => c.Description == selectedCategoryDescription);

                if (dropDownAccountExpense.SelectedItem != null) {
                    string selectedAccountName = dropDownAccountExpense.SelectedItem.ToString();
                    var selectedAccount = App.State.UserManager.LoggedUser.Accounts.FirstOrDefault(a => a.Name == selectedAccountName);

                    if (selectedAccount != null) {
                        decimal amount;
                        if (decimal.TryParse(txtValueAddExpense.Text, out amount)) {
                            Transaction newTransaction = new Transaction(creatorAccount: App.State.UserManager.LoggedUser.Accounts.First().ID) {
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
                        else {
                            MessageBox.Show("Please enter a valid amount.");
                        }
                    }
                    else {
                        MessageBox.Show("Selected account is not valid.");
                    }
                }
                else {
                    MessageBox.Show("Please select an account.");
                }
            }
            else {
                MessageBox.Show("Please select a category.");
            }
        }


    }
}


