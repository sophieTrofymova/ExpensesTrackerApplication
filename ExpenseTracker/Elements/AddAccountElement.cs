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
        public AddAccountElement() {
            InitializeComponent();
        }

        public override void Init() {
            // Initialize the accounts element here
            // For example, load account data from a database or file
            // and populate the UI controls with that data.



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

            var newAccount = new Account(name, balance);
            App.State.UserManager.LoggedUser.Accounts.Add(newAccount);

            WF.MessageBox.Show($"Account '{name}' added with €{balance:F2} balance.");

            txtAccountName.Text = "";
            txtInitialBalance.Text = "";

            ReturnToAccountsScreen();

        }


        private void ReturnToAccountsScreen() {
            var container = (this.Parent as ElementContainer);
            container.UnlockView();


            container.CurrentView.SwitchScreen("view");

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            ReturnToAccountsScreen();

        }
    }
}
