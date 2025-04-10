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

            var acc = Session.CurrentUser?.Accounts.Select(a => a).Where(a => a.Name == (cbUserAccounts.SelectedItem as string)).FirstOrDefault() as Account;
            var cat = CategoryInfo.ExpenseCategories.Select(c => c).Where(c => c.Description == (expenseCategoryDropDown.SelectedItem as string)).FirstOrDefault() as CategoryInfo;

            var transaction = new Transaction(acc.ID) {
                Amount = decimal.Parse(tbExpenseAmount.Text),
                EffectDate = dtpAffectDate.Value,
                CategoryInfo = cat,
                Type = TransactionType.Expense
            };

            Session.CurrentUser?.Transactions.Add(transaction);

            var container = (this.Parent as ElementContainer);
            container?.UnlockView();
            this.ParentView?.SwitchScreen("view");
        }

        private void bCancel_Click(object sender, EventArgs e) {
            var container = (this.Parent as ElementContainer);
            container?.UnlockView();
            this.ParentView?.SwitchScreen("view");
        }
    }
}
