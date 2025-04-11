using ExpenseTracker.Controls;
using ExpenseTracker.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Elements {
    public partial class AddExpenseElement : Element {

        public AddExpenseElement(ElementView parentView) : base(parentView) {
            InitializeComponent();
        }

        public override void Init() {


            expenseCategoryDropDown.Items.Clear();
            var expenseCategories = CategoryInfo.ExpenseCategories.Select(c => c.Description).ToArray();
            expenseCategoryDropDown.Items.AddRange(expenseCategories);


            cbUserAccounts.Items.Clear();
            var accounts = Session.CurrentUser?.Accounts.Select(a => a.Name).ToArray();
            cbUserAccounts.Items.AddRange(accounts);

        }

        private void bAdd_Click(object sender, EventArgs e) {

            //var acc = Session.CurrentUser?.Accounts.Select(a => a).Where(a => a.Name == (cbUserAccounts.SelectedItem as string)).FirstOrDefault() as Account;
            //var cat = CategoryInfo.ExpenseCategories.Select(c => c).Where(c => c.Description == (expenseCategoryDropDown.SelectedItem as string)).FirstOrDefault() as CategoryInfo;

            //var transaction = new Transaction(acc.ID) {
            //    Amount = decimal.Parse(tbExpenseAmount.Text),
            //    EffectDate = dtpAffectDate.Value,
            //    CategoryInfo = cat,
            //    Type = TransactionType.Expense
            //};

            //Session.CurrentUser?.Transactions.Add(transaction);

            //var container = (this.Parent as ElementContainer);
            //container?.UnlockView();
            //this.ParentView?.SwitchScreen("view");

            if (cbUserAccounts.SelectedItem == null || expenseCategoryDropDown.SelectedItem == null)
            {
                MessageBox.Show("Please select an account and category.");
                return;
            }

            var acc = Session.CurrentUser?.Accounts
                .FirstOrDefault(a => a.Name == cbUserAccounts.SelectedItem.ToString());

            var cat = CategoryInfo.ExpenseCategories
                .FirstOrDefault(c => c.Description == expenseCategoryDropDown.SelectedItem.ToString());

            if (acc == null || cat == null)
            {
                MessageBox.Show("Invalid account or category.");
                return;
            }

            if (!decimal.TryParse(tbExpenseAmount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            var transaction = new Transaction(acc.ID)
            {
                Amount = amount,
                EffectDate = dtpAffectDate.Value,
                CategoryInfo = cat,
                Type = TransactionType.Expense
            };

            Session.CurrentUser?.Transactions.Add(transaction);

            var matchingBudget = Session.CurrentUser?.Budgets
                .FirstOrDefault(b =>
                    b.CategoryInfo.Description == cat.Description &&
                    b.AccountsIDs.Contains(acc.ID));

            if (matchingBudget != null)
            {
                matchingBudget.Spent += amount;
            }

            MessageBox.Show("Expense added successfully.");

            var container = (this.Parent as ElementContainer);
            container?.UnlockView();
            this.SwitchToLocalScreen("view",false);

        }

        private void bCancel_Click(object sender, EventArgs e) {
            SwitchToLocalScreen("view",false);
        }



    }
}
