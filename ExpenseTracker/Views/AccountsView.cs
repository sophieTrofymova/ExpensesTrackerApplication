﻿//using global::ExpenseTracker.Controls;

//namespace ExpenseTracker.Views {

//    namespace ExpenseTracker {
//        public class AccountsView: ElementView {
//            public AccountsView(ElementContainer container, string name = "Accounts") : base(name, container) { }

//            public override void Build() {
//                base.Build();

//                this.NumCols = 6;
//                this.NumRows = 2;

//                var accounts = new Element {
//                    GroupBox = { Text = "Accounts" },
//                    Col = 0,
//                    Cols = 6,
//                    AllowDrag = false
//                };

//                this.AddElements(new List<Element> { accounts });
//            }
//        }

//    }

//}
using ExpenseTracker;
using ExpenseTracker.Elements;
using ExpenseTracker.Controls;
using WF = System.Windows.Forms;

namespace ExpenseTracker.Views
{
    public class AccountsView : ElementView
    {
        private WF.ListView accountsListView;
        private WF.TextBox txtAccountName;
        private WF.TextBox txtInitialBalance;


        private ListView accountsListView;
        public AccountsView(ElementContainer container, string name = "Accounts") : base(name, container)
        {
            this.NumRows = 10;
            this.NumCols = 20;
            Padding = new WF.Padding(25);
        }
        public override void Build()
        {
            this.ClearElements();

            var accountsElement = new AccountsElement()
            {
                Title = "Accounts",
                Col = 0,
                Row = 0,
                Cols = 20,
                Rows = 4,
                AllowDrag = false
            };




            AddElements(new List<Element> { accountsElement });

        }

        public  void Build2()
        {

            var accountsGroupBox = new Element();
            accountsGroupBox.GroupBox.Text = $"";
            accountsGroupBox.Col = 7;
            accountsGroupBox.Row = 4;
            accountsGroupBox.Cols = 14;
            accountsGroupBox.Rows = 8;
            accountsGroupBox.AllowDrag = false;

            accountsListView = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Location = new System.Drawing.Point(10, 25),
                Size = new System.Drawing.Size(550, 250),
                Dock = DockStyle.Fill,
                Columns =
                {
                    new WF.ColumnHeader { Text = "Account Name", Width = 200 },
                    new WF.ColumnHeader { Text = "Balance (€)", Width = 150 }
                }
            };

            accountsGroupBox.GroupBox.Controls.Add(accountsListView);
            LoadUserAccounts(accountsListView);


            // GroupBox to add new account
            var addAccountElement = new Element()
            {
                Title = "Add Account",
                Col = 0,
                Row = 4,
                Cols = 10,
                Rows = 4,
                AllowDrag = false
            };

            var lblName = new WF.Label
            {
                Text = "Account Name:",
                Location = new System.Drawing.Point(30, 50),
                AutoSize = true
            };

            var txtName = new WF.TextBox
            {
                Location = new System.Drawing.Point(250, 50),
                Width = 150
            };

            var lblBalance = new WF.Label
            {
                Text = "Initial Balance (€):",
                Location = new System.Drawing.Point(30, 120),
                AutoSize = true
            };

            var txtBalance = new WF.TextBox
            {
                Location = new System.Drawing.Point(250, 120),
                Width = 150
            };

            var btnAdd = new WF.Button
            {
                Text = "Add Account",
                Location = new System.Drawing.Point(250, 200),
                Size = new System.Drawing.Size(120, 40),
                BackColor = System.Drawing.Color.LightGreen
            };
            btnAdd.Click += (sender, e) => btnAdd_Click(sender, e, txtName, txtBalance);

            addAccountElement.GroupBox.Controls.Add(lblName);
            addAccountElement.GroupBox.Controls.Add(txtName);
            addAccountElement.GroupBox.Controls.Add(lblBalance);
            addAccountElement.GroupBox.Controls.Add(txtBalance);
            addAccountElement.GroupBox.Controls.Add(btnAdd);

            AddElements(new List<Element> { accountsElement, addAccountElement });
        }



        private void btnAdd_Click(object sender, EventArgs e, WF.TextBox txtAccountName, WF.TextBox txtInitialBalance)
        {
            string name = txtAccountName.Text.Trim();
            string balanceText = txtInitialBalance.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(balanceText))
            {
                WF.MessageBox.Show("Please enter both account name and balance.");
                return;
            }

            if (!decimal.TryParse(balanceText, out decimal balance))
            {
                WF.MessageBox.Show("Please enter a valid number for balance.");
                return;
            }

            var newAccount = new Account(name, balance);
            MainForm.AppState.UserManager.LoggedUser.Accounts.Add(newAccount);

            WF.MessageBox.Show($"Account '{name}' added with €{balance:F2} balance.");

            txtAccountName.Text = "";
            txtInitialBalance.Text = "";

            LoadUserAccounts(accountsListView);
        }



        private void LoadUserAccounts(WF.ListView listView)
        {
            listView.Items.Clear();
            if (MainForm.AppState.UserManager.LoggedUser?.Accounts != null)
            {
                foreach (var acc in MainForm.AppState.UserManager.LoggedUser.Accounts)
                {
                    var item = new WF.ListViewItem(new[] { acc.Name, acc.Balance.ToString("F2") });
                    listView.Items.Add(item);
                }
            }
        }

    }
}

