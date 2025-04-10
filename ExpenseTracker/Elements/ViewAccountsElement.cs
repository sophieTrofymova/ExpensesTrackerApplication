using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF=System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using ExpenseTracker.Controls;
using ExpenseTracker.Views;

namespace ExpenseTracker.Elements
{
    public partial class ViewAccountsElement : Element {
        public ViewAccountsElement() {
            InitializeComponent();
        }

        public override void Init() {
            // Initialize the accounts element here
            // For example, load account data from a database or file
            // and populate the UI controls with that data.


            dgvAccounts.AutoSizeColumnsMode = WF.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.AllowUserToAddRows = false;

            dgvAccounts.Columns.Add("AccountName", "Account Name");
            dgvAccounts.Columns.Add("Balance", "Balance");

            var deleteButton = new WF.DataGridViewButtonColumn {
                Name = "Delete",
                HeaderText = "Actions",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            };
            dgvAccounts.Columns.Add(deleteButton);


            dgvAccounts.CellClick += (sender, e) => {
                if (e.RowIndex < 0 || e.ColumnIndex != dgvAccounts.Columns["Delete"].Index)
                    return;

                var result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    string accountName = dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString();

                    var accountToRemove = App.State.UserManager.LoggedUser.Accounts.FirstOrDefault(a => a.Name == accountName);
                    if (accountToRemove != null)
                        App.State.UserManager.LoggedUser.Accounts.Remove(accountToRemove);

                    dgvAccounts.Rows.RemoveAt(e.RowIndex);
                }
            };

            RefreshDataGrid();

        }

        private void RefreshDataGrid() {
            dgvAccounts.Rows.Clear();
            var accounts = App.State.UserManager.LoggedUser?.Accounts;
            if (accounts != null) {
                foreach (var acc in accounts) {
                    dgvAccounts.Rows.Add(acc.Name, acc.Balance.ToString("F2"));
                }
            }
        }

      
        private void bAddAccount_Click(object sender, EventArgs e) {

     


            var container = (this.Parent as ElementContainer);
            container.CurrentView.SwitchScreen("add");
            container.LockView();
        }
    }
}
