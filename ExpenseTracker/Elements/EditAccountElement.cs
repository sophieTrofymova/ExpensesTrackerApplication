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
    public partial class EditAccountElement : Element {

        private Account? accountToChange = null;

        public EditAccountElement(ElementView parentView) : base(parentView) {
            InitializeComponent();
        }

        public override void Init() {
            accountToChange = Session.SelectedAccount();

            if (accountToChange == null) {
                ReturnToAccountsScreen();
            }


            txtAccountName.Text = accountToChange.Name;
            txtInitialBalance.Text = accountToChange.Balance.ToString("F2");
        }

        private void btnEdit_Click(object sender, EventArgs e) {

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

            // update the acc values
            accountToChange.Name = name;
            accountToChange.Balance = balance;

            WF.MessageBox.Show($"Account updated: '{name}' with €{balance:F2}");

            txtAccountName.Text = "";
            txtInitialBalance.Text = "";

            ReturnToAccountsScreen();

        }

        private void ReturnToAccountsScreen() {
            var container = this.ParentView?.Container;

            if (container == null) {
                throw new NullReferenceException("Parent container is not set");
            }

            container?.UnlockView();
            container?.CurrentView?.SwitchScreen("view");

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            ReturnToAccountsScreen();

        }      
    }
}
