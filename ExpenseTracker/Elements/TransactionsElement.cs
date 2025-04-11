using ExpenseTracker.Controls;
using System.Data;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Elements {
    public partial class TransactionsElement : Element {

        public bool FFExpenses { get { return cbExpenses.Checked; } }
        public bool FFIncome { get { return cbIncome.Checked; } }
        public bool FFTransfer { get { return cbTransfers.Checked; } }

        public Account? FFSelectedAccount {
            get {
                Account? acc = user.Accounts.Select(a => a).Where(a => a.Name == accountsDropDown.Text).FirstOrDefault();
                return acc;
            }
        }

        public string FFCategory {
            get {
                return categoriesDropDown.Text;
            }
        }


        User user = Session.CurrentUser;

        public TransactionsElement(ElementView parentView) : base(parentView) {
            InitializeComponent();


        }


        public override void Init() {


            RefreshDropdowns();

            RefreshTransactionList();

        }

        private Transaction? GetSelectedTransaction() {
            if (transactionsList.SelectedItems.Count == 0)
                return null;

            return transactionsList.SelectedItems[0].Tag as Transaction;
        }

        private void RefreshTransactionList() {
            var transactions = user.Transactions;

            transactionsList.Items.Clear();
            transactionsList.Clear();

            transactionsList.View = View.Details;
            transactionsList.FullRowSelect = true;
            transactionsList.MultiSelect = false;

            transactionsList.FullRowSelect = true;
            transactionsList.GridLines = true;

            transactionsList.Columns.AddRange(
                new[] {
                    new WF.ColumnHeader { Text = "Type", Width = 120 },
                    new WF.ColumnHeader { Text = "Date", Width = 150 },
                    new WF.ColumnHeader { Text = "Category", Width = 180 },
                    new WF.ColumnHeader { Text = "Amount", Width = 150 },
                    new WF.ColumnHeader { Text = "Sender Account", Width = 200 },
                    new WF.ColumnHeader { Text = "Receiver Account", Width = 200 }
                }
            );


            foreach (var t in transactions) {

                // if there any category selected, and the transaction category is not equal to the selected category, skip it
                if (FFCategory != "" && t.CategoryInfo.Description != FFCategory)
                    continue;

                // if there any account selected, and the transaction sender account is not equal to the selected account, skip it
                if (FFSelectedAccount != null) {
                    if (t.SenderAccount != FFSelectedAccount.ID) {
                        continue;
                    }
                }

                // if there any month selected, and the transaction date is not equal to the selected month, skip it
                if (monthDropDown.Text != "" && t.EffectDate.ToString("MMMM") != monthDropDown.Text) {
                    continue;
                }
                // if income flag turned off and transaction type is income, skip it
                if ((!FFIncome && t.Type == TransactionType.Income)) {
                    continue;
                }
                // if expense flag turned off and transaction type is expense, skip it
                if ((!FFExpenses && t.Type == TransactionType.Expense)) {
                    continue;
                }
                // if transfer flag turned off and transaction type is transfer, skip it
                if ((!FFTransfer && t.Type == TransactionType.Transfer)) {
                    continue;
                }

                var item = new ListViewItem(t.Type.ToString());
                item.SubItems.Add(t.EffectDate.ToString("dd MMM yyyy"));
                item.SubItems.Add(t.CategoryDescription);
                item.SubItems.Add(t.Amount.ToCurrencyString(App.State.Settings.CurrencyType));

                Account? sender = user.Accounts.Select(a => a).Where(a => a.ID == t.SenderAccount).FirstOrDefault();
                Account? receiver = user.Accounts.Select(a => a).Where(a => a.ID == t.ReceiverAccount).FirstOrDefault();

                item.SubItems.Add((sender == null) ? "" : sender.Name);
                item.SubItems.Add((receiver == null) ? "" : receiver.Name);

                item.Tag = t; // keep original Transaction obj for later use

                transactionsList.Items.Add(item);

            }
        }


        public void RefreshDropdowns() {
            var incomeCategories = CategoryInfo.IncomeCategories.Select(c => c.Description).ToList();
            var expenseCategories = CategoryInfo.ExpenseCategories.Select(c => c.Description).ToList();

            List<string> categories = [.. incomeCategories, .. expenseCategories];

            categoriesDropDown.Items.Clear();
            categoriesDropDown.Items.AddRange(categories.ToArray());

            accountsDropDown.Items.Clear();
            foreach (Account acc in user.Accounts) {
                accountsDropDown.Items.Add(acc.Name);
            }

        }






        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void categoriesDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshTransactionList();
        }

        private void accountsDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshTransactionList();
        }

        private void monthDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshTransactionList();
        }

        private void cbExpenses_CheckedChanged(object sender, EventArgs e) {
            RefreshTransactionList();
        }

        private void cbIncome_CheckedChanged(object sender, EventArgs e) {
            RefreshTransactionList();
        }

        private void cbTransfers_CheckedChanged(object sender, EventArgs e) {
            RefreshTransactionList();
        }

        private void bResetFilter_Click(object sender, EventArgs e) {
            cbExpenses.Checked = true;
            cbIncome.Checked = true;
            cbTransfers.Checked = true;

            categoriesDropDown.SelectedIndex = -1;
            accountsDropDown.SelectedIndex = -1;
            monthDropDown.SelectedIndex = -1;
        }

        private void bAddExpense_Click(object sender, EventArgs e) {
            SwitchToLocalScreen("addExpense", true);
        }

        private void bAddIncome_Click(object sender, EventArgs e) {
            SwitchToLocalScreen("addIncome", true);
        }

        private void bAddTransfer_Click(object sender, EventArgs e) {
            SwitchToLocalScreen("addTransfer", true);
        }


        private void bDeleteTransaction_Click(object sender, EventArgs e) {
            var transaction = GetSelectedTransaction();

            if (transaction == null) {
                WF.MessageBox.Show("Please select a transaction to delete.", "No Selection", WF.MessageBoxButtons.OK, WF.MessageBoxIcon.Information);
                return;
            }

            var confirm = WF.MessageBox.Show(
                $"Are you sure you want to delete this transaction?\n\n" +
                $"{transaction.EffectDate:dd MMM yyyy} - {transaction.CategoryDescription} - {transaction.Amount.ToCurrencyString(App.State.Settings.CurrencyType)}",
                "Confirm Deletion",
                WF.MessageBoxButtons.YesNo,
                WF.MessageBoxIcon.Warning
            );

            if (confirm == WF.DialogResult.Yes) {
                user.Transactions.Remove(transaction);
                RefreshTransactionList();
            }
        }

        private void bEditTransaction_Click(object sender, EventArgs e) {
            var transaction = GetSelectedTransaction();

            if (transaction == null) {
                WF.MessageBox.Show("Please select a transaction to edit.", "No Selection", WF.MessageBoxButtons.OK, WF.MessageBoxIcon.Information);
                return;
            }

            Session.SelectedTransactionId = transaction?.ID;

            SwitchToLocalScreen("editTransaction", true);
        }
    }
}
