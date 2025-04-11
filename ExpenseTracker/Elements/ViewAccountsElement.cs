using System;
using System.Linq;
using System.Windows.Forms;
using ExpenseTracker.Controls;
using ExpenseTracker.Views;
using ExpenseTracker.Views.ExpenseTracker;

namespace ExpenseTracker.Elements {
    public partial class ViewAccountsElement : Element {
        public ViewAccountsElement(ElementView parentView) : base(parentView) {

            InitializeComponent();

        }

        public override void Init() {

            lvAccounts.View = View.Details;
            lvAccounts.FullRowSelect = true;
            lvAccounts.MultiSelect = false;
            lvAccounts.Columns.Clear();
            lvAccounts.Columns.Add("Account Name", 250);
            lvAccounts.Columns.Add("Balance", 300);

            lvAccounts.MouseDoubleClick += LvAccounts_MouseDoubleClick;

            RefreshAccountList();

        }
        
        private void RefreshAccountList() {

            lvAccounts.Items.Clear();

            var accounts = Session.CurrentUser?.Accounts;
            if (accounts != null) {
                foreach (var acc in accounts) {
                    var item = new ListViewItem(acc.Name);
                    item.SubItems.Add(acc.Balance.ToString("F2"));
                    item.Tag = acc; // keep original Account obj for later use
                    lvAccounts.Items.Add(item);
                }
            }

        }

        private Account? GetSelectedAccount() {
            if (lvAccounts.SelectedItems.Count == 0)
                return null;

            return lvAccounts.SelectedItems[0].Tag as Account;
        }

        private void LvAccounts_MouseDoubleClick(object? sender, MouseEventArgs e) {

            if (lvAccounts.SelectedItems.Count == 0) return;

            var item = lvAccounts.SelectedItems[0];
            var acc = item.Tag as Account;

            if (acc != null) {
                var result = MessageBox.Show($"Delete account '{acc.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    Session.CurrentUser?.Accounts.Remove(acc);
                    RefreshAccountList();
                }
            }

        }

        private void bAddAccount_Click(object sender, EventArgs e) {

            var container = this.Parent as ElementContainer;
            container?.CurrentView?.SwitchScreen("add");
            container?.LockView();

        }

        private void bEditAccount_Click(object sender, EventArgs e) {

            var acc = GetSelectedAccount();

            if (acc == null) {
                MessageBox.Show("You need to select account first");
                return;
            }

            Session.SelectedAccountId = acc.ID;

            var container = this.Parent as ElementContainer;
            if (container?.CurrentView is AccountsView view) {
                view.SwitchScreen("edit");
                container.LockView();
            }

        }

        //private void bEditBudget_Click(object sender, EventArgs e) {

        //    var budget = GetSelectedBudget(); // создай метод GetSelectedBudget() аналогично GetSelectedAccount() в ViewAccountsElement

        //    if (budget == null) {
        //        MessageBox.Show("You need to select budget first");
        //        return;
        //    }

        //    Session.SelectedBudgetId = budget.ID;

        //    if (this.ParentView is BudgetsView view) {
        //        view.SwitchScreen("editBudget"); // или как у тебя называется
        //        this.ParentView.Container.LockView();
        //    }

        //}


        private void tbDeleteAccount_Click(object sender, EventArgs e) {

            var acc = GetSelectedAccount();
            if (acc == null) {
                MessageBox.Show("Please select an account to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete the account '{acc.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes) {
                Session.CurrentUser?.Accounts.Remove(acc);
                RefreshAccountList();
            }

        }

    }
}
