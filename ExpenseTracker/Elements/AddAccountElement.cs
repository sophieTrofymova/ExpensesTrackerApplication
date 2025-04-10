using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF = System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using ExpenseTracker.Controls;
using ExpenseTracker.Views;
using Newtonsoft.Json.Linq;

namespace ExpenseTracker.Elements {
    public partial class AddAccountElement : Element {
        public AddAccountElement(ElementView parentView) : base(parentView) {
            InitializeComponent();
        }

        public override void Init() {
     
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            string name = txtAccountName.Text.Trim();
            string balanceText = txtInitialBalance.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(balanceText)) {
                WF.MessageBox.Show("Please enter both account name and balance.");
                return;
            }

            if (!decimal.TryParse(balanceText, out decimal balance)) {
                WF.MessageBox.Show("Please enter a valid number for balance.");
                return;
            }

            // check for duplicate acc name
            if (Session.CurrentUser.Accounts.Any(acc => acc.Name.Equals(name, StringComparison.OrdinalIgnoreCase))) {
                WF.MessageBox.Show("An account with this name already exists.");
                return;
            }

            var newAccount = new Account(name, balance);
            Session.CurrentUser.Accounts.Add(newAccount);

            WF.MessageBox.Show($"Account '{name}' added with €{balance:F2} balance.");


            txtAccountName.Text = "";
            txtInitialBalance.Text = "";

            ReturnToAccountsScreen();

        }
        private void btnCancel_Click(object sender, EventArgs e) {
            ReturnToAccountsScreen();

        }

        private void ReturnToAccountsScreen() {
            ElementContainer? container = (this.Parent as ElementContainer);
            container?.UnlockView();
            container?.CurrentView?.SwitchScreen("view");
        }


    }
}
