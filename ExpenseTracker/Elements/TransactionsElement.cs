using ExpenseTracker.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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


        User user = App.State.UserManager.LoggedUser;

        public TransactionsElement(ElementView parentView) : base(parentView) {
            InitializeComponent();


        }


        public override void Init() {


            FillCategories();
            FillAccounts();
            InitList();
            FillTransactions();


        }

        public void InitList() {
            transactionsList.Clear();
            transactionsList.FullRowSelect = true;
            transactionsList.GridLines = true;

            transactionsList.Columns.AddRange(
                new[] {
                    new WF.ColumnHeader { Text = "Date", Width = 120 },
                    new WF.ColumnHeader { Text = "Category", Width = 180 },
                    new WF.ColumnHeader { Text = "Amount", Width = 100 },
                    new WF.ColumnHeader { Text = "Sender Account", Width = 100 },
                    new WF.ColumnHeader { Text = "Receiver Account", Width = 100 }
                }
            );
        }

        public void FillCategories() {
            var incomeCategories = CategoryInfo.IncomeCategories.Select(c => c.Description).ToList();
            var expenseCategories = CategoryInfo.ExpenseCategories.Select(c => c.Description).ToList();

            List<string> categories = [.. incomeCategories, .. expenseCategories];

            categoriesDropDown.Items.Clear();
            categoriesDropDown.Items.AddRange(categories.ToArray());

        }

        public void FillAccounts() {
            accountsDropDown.Items.Clear();
            foreach (Account acc in user.Accounts) {
                accountsDropDown.Items.Add(acc.Name);
            }
        }

        public void FillTransactions() {
            var transactions = user.Transactions;
            transactionsList.Items.Clear();

            foreach (var transaction in transactions) {

                if (FFCategory != "" && transaction.CategoryInfo.Description != FFCategory)
                    continue;
                if (FFSelectedAccount != null) {
                    if (transaction.SenderAccount != FFSelectedAccount.ID) {
                        continue;
                    }
                }
                if (monthDropDown.Text != "" && transaction.EffectDate.ToString("MMMM") != monthDropDown.Text) {
                    continue;
                }

                if ((!FFIncome && transaction.Type == TransactionType.Income)) {
                    continue;
                }

                if ((!FFExpenses && transaction.Type == TransactionType.Expense)) {
                    continue;
                }

                if ((!FFTransfer && transaction.Type == TransactionType.Transfer)) {
                    continue;
                }


                var item = new ListViewItem(transaction.EffectDate.ToString("dd MMM yyyy"));
                item.SubItems.Add(transaction.CategoryDescription);
                item.SubItems.Add(transaction.Amount.ToCurrencyString(App.State.Settings.CurrencyType));


                Account? sender = user.Accounts.Select(a => a).Where(a => a.ID == transaction.SenderAccount).FirstOrDefault();

                Account? receiver = user.Accounts.Select(a => a).Where(a => a.ID == transaction.ReceiverAccount).FirstOrDefault();



                item.SubItems.Add((sender == null) ? "" : sender.Name);
                item.SubItems.Add((receiver == null) ? "" : receiver.Name);

                transactionsList.Items.Add(item);
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void categoriesDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            FillTransactions();
        }

        private void accountsDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            FillTransactions();
        }

        private void monthDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            FillTransactions();
        }

        private void cbExpenses_CheckedChanged(object sender, EventArgs e) {
            FillTransactions();
        }

        private void cbIncome_CheckedChanged(object sender, EventArgs e) {
            FillTransactions();
        }

        private void cbTransfers_CheckedChanged(object sender, EventArgs e) {
            FillTransactions();
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

            var parent = (this.Parent as ElementContainer);
            ParentView.SwitchScreen("addExpense");
            parent.LockView();

        }

        private void bAddIncome_Click(object sender, EventArgs e) {
            var parent = (this.Parent as ElementContainer);
            ParentView.SwitchScreen("addIncome");
            parent.LockView();
        }

        private void bAddTransfer_Click(object sender, EventArgs e) {
            var parent = (this.Parent as ElementContainer);
            ParentView.SwitchScreen("addTransfer");
            parent.LockView();
        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void bCategory_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e) {
            FillCategories();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

  
    }
}
