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
    public partial class AddIncomeElement : Element {

        public AddIncomeElement(ElementView parentView) : base(parentView) {
            InitializeComponent();
        }

        public override void Init() {


            IncomeCategoryDropDown.Items.Clear();
            var incomeCategories = CategoryInfo.IncomeCategories.Select(c => c.Description).ToArray();
            IncomeCategoryDropDown.Items.AddRange(incomeCategories);


            cbUserAccounts.Items.Clear();
            var accounts = Session.CurrentUser?.Accounts.Select(a => a.Name).ToArray();
            cbUserAccounts.Items.AddRange(accounts);

        }

        private void bAdd_Click(object sender, EventArgs e) {

            var acc = Session.CurrentUser?.Accounts.Select(a => a).Where(a => a.Name == (cbUserAccounts.SelectedItem as string)).FirstOrDefault() as Account;
            var cat = CategoryInfo.IncomeCategories.Select(c => c).Where(c => c.Description == (IncomeCategoryDropDown.SelectedItem as string)).FirstOrDefault() as CategoryInfo;

            var transaction = new Transaction(acc.ID) {
                Amount = decimal.Parse(tbIncomeAmount.Text),
                EffectDate = dtpAffectDate.Value,
                CategoryInfo = cat,
                Type = TransactionType.Income
            };

            Session.CurrentUser?.Transactions.Add(transaction);

            SwitchToLocalScreen("view",false);

        }

        private void bCancel_Click(object sender, EventArgs e) {

            SwitchToLocalScreen("view",false);

        }
    }
}
