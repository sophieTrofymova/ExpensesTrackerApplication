////using global::ExpenseTracker.Controls;

////namespace ExpenseTracker.Views {

////    namespace ExpenseTracker {
////        public class AccountsView: ElementView {
////            public AccountsView(ElementContainer container, string name = "Accounts") : base(name, container) { }

////            public override void Build() {
////                base.Build();

////                this.NumCols = 6;
////                this.NumRows = 2;

////                var accounts = new Element {
////                    GroupBox = { Text = "Accounts" },
////                    Col = 0,
////                    Cols = 6,
////                    AllowDrag = false
////                };

////                this.AddElements(new List<Element> { accounts });
////            }
////        }

////    }

////}
//using ExpenseTracker;
//using ExpenseTracker.Elements;
//using ExpenseTracker.Controls;
//using WF = System.Windows.Forms;

//namespace ExpenseTracker.Views
//{
//    public class AccountsView : ElementView
//    {
//        private WF.ListView accountsListView;
//        private WF.TextBox txtAccountName;
//        private WF.TextBox txtInitialBalance;


//        private ListView accountsListView;
//        public AccountsView(ElementContainer container, string name = "Accounts") : base(name, container)
//        {
//            this.NumRows = 10;
//            this.NumCols = 20;
//            Padding = new WF.Padding(25);
//        }
//        public override void Build()
//        {
//            this.ClearElements();

//            var accountsElement = new AccountsElement()
//            {
//                Title = "Accounts",
//                Col = 0,
//                Row = 0,
//                Cols = 20,
//                Rows = 4,
//                AllowDrag = false
//            };




//            AddElements(new List<Element> { accountsElement });

//        }

//        public  void Build2()
//        {

//            var accountsGroupBox = new Element();
//            accountsGroupBox.GroupBox.Text = $"";
//            accountsGroupBox.Col = 7;
//            accountsGroupBox.Row = 4;
//            accountsGroupBox.Cols = 14;
//            accountsGroupBox.Rows = 8;
//            accountsGroupBox.AllowDrag = false;

//            accountsListView = new ListView
//            {
//                View = View.Details,
//                FullRowSelect = true,
//                GridLines = true,
//                Location = new System.Drawing.Point(10, 25),
//                Size = new System.Drawing.Size(550, 250),
//                Dock = DockStyle.Fill,
//                Columns =
//                {
//                    new WF.ColumnHeader { Text = "Account Name", Width = 200 },
//                    new WF.ColumnHeader { Text = "Balance (€)", Width = 150 }
//                }
//            };

//            accountsGroupBox.GroupBox.Controls.Add(accountsListView);
//            LoadUserAccounts(accountsListView);


//            // GroupBox to add new account
//            var addAccountElement = new Element()
//            {
//                Title = "Add Account",
//                Col = 0,
//                Row = 4,
//                Cols = 10,
//                Rows = 4,
//                AllowDrag = false
//            };

//            var lblName = new WF.Label
//            {
//                Text = "Account Name:",
//                Location = new System.Drawing.Point(30, 50),
//                AutoSize = true
//            };

//            var txtName = new WF.TextBox
//            {
//                Location = new System.Drawing.Point(250, 50),
//                Width = 150
//            };

//            var lblBalance = new WF.Label
//            {
//                Text = "Initial Balance (€):",
//                Location = new System.Drawing.Point(30, 120),
//                AutoSize = true
//            };

//            var txtBalance = new WF.TextBox
//            {
//                Location = new System.Drawing.Point(250, 120),
//                Width = 150
//            };

//            var btnAdd = new WF.Button
//            {
//                Text = "Add Account",
//                Location = new System.Drawing.Point(250, 200),
//                Size = new System.Drawing.Size(120, 40),
//                BackColor = System.Drawing.Color.LightGreen
//            };
//            btnAdd.Click += (sender, e) => btnAdd_Click(sender, e, txtName, txtBalance);

//            addAccountElement.GroupBox.Controls.Add(lblName);
//            addAccountElement.GroupBox.Controls.Add(txtName);
//            addAccountElement.GroupBox.Controls.Add(lblBalance);
//            addAccountElement.GroupBox.Controls.Add(txtBalance);
//            addAccountElement.GroupBox.Controls.Add(btnAdd);

//            AddElements(new List<Element> { accountsElement, addAccountElement });
//        }



//        private void btnAdd_Click(object sender, EventArgs e, WF.TextBox txtAccountName, WF.TextBox txtInitialBalance)
//        {
//            string name = txtAccountName.Text.Trim();
//            string balanceText = txtInitialBalance.Text.Trim();

//            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(balanceText))
//            {
//                WF.MessageBox.Show("Please enter both account name and balance.");
//                return;
//            }

//            if (!decimal.TryParse(balanceText, out decimal balance))
//            {
//                WF.MessageBox.Show("Please enter a valid number for balance.");
//                return;
//            }

//            var newAccount = new Account(name, balance);
//            MainForm.AppState.UserManager.LoggedUser.Accounts.Add(newAccount);

//            WF.MessageBox.Show($"Account '{name}' added with €{balance:F2} balance.");

//            txtAccountName.Text = "";
//            txtInitialBalance.Text = "";

//            LoadUserAccounts(accountsListView);
//        }



//        private void LoadUserAccounts(WF.ListView listView)
//        {
//            listView.Items.Clear();
//            if (MainForm.AppState.UserManager.LoggedUser?.Accounts != null)
//            {
//                foreach (var acc in MainForm.AppState.UserManager.LoggedUser.Accounts)
//                {
//                    var item = new WF.ListViewItem(new[] { acc.Name, acc.Balance.ToString("F2") });
//                    listView.Items.Add(item);
//                }
//            }
//        }

//    }
//}
using ExpenseTracker;
using ExpenseTracker.Elements;
using ExpenseTracker.Controls;
using WF = System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ExpenseTracker.Views
{
    public class AccountsView : ElementView
    {
        private WF.DataGridView dgvAccounts;
        private WF.Panel addAccountPanel;

        public AccountsView(ElementContainer container, string name = "Accounts") : base(name, container)
        {
            this.NumRows = 10;
            this.NumCols = 20;
            Padding = new WF.Padding(25);
        }

        public override void Build()
        {
            this.ClearElements();

            var accountsElement = new Element
            {
                Title = "Accounts",
                Col = 0,
                Row = 0,
                Cols = 20,
                Rows = 10,
                AllowDrag = false
            };

            dgvAccounts = new WF.DataGridView
            {
                Name = "dgvAccounts",
                Size = new Size(1000, 300),
                Location = new Point(20, 30),
                AutoSizeColumnsMode = WF.DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White
            };

            dgvAccounts.Columns.Add("AccountName", "Account Name");
            dgvAccounts.Columns.Add("Balance", "Balance");

            var deleteButton = new WF.DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Actions",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                 FlatStyle = FlatStyle.Flat
            };
            dgvAccounts.Columns.Add(deleteButton);


            dgvAccounts.CellClick += (sender, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex != dgvAccounts.Columns["Delete"].Index)
                    return;

                var result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string accountName = dgvAccounts.Rows[e.RowIndex].Cells[0].Value.ToString();

                    var accountToRemove = MainForm.AppState.UserManager.LoggedUser.Accounts.FirstOrDefault(a => a.Name == accountName);
                    if (accountToRemove != null)
                        MainForm.AppState.UserManager.LoggedUser.Accounts.Remove(accountToRemove);

                    dgvAccounts.Rows.RemoveAt(e.RowIndex);
                }
            };


           var pnlAddAccount = new Panel
            {
                Location = new Point(20, 350),
                Size = new Size(600, 600),
                Visible = false 
            };

            var lblName = new Label { Text = "Account Name:", Location = new Point(10, 10), AutoSize = true };
            var txtAccountName = new TextBox { Location = new Point(210, 10), Width = 200 };

            var lblBalance = new Label { Text = "Initial Balance:", Location = new Point(10, 80), AutoSize = true };
            var txtInitialBalance = new TextBox { Location = new Point(210, 80), Width = 200 };

            var btnAdd = new Button
            {
                Text = "Add",
                Location = new Point(330, 150),
                Size = new Size(80, 30),
                BackColor = Color.LightGreen
            };

            btnAdd.Click += (s, e) => btnAdd_Click(txtAccountName, txtInitialBalance);
            pnlAddAccount.Controls.Add(lblName);
            pnlAddAccount.Controls.Add(txtAccountName);
            pnlAddAccount.Controls.Add(lblBalance);
            pnlAddAccount.Controls.Add(txtInitialBalance);
            pnlAddAccount.Controls.Add(btnAdd);

            var btnToggleAddForm = new Button
            {
                Text = "+",
                Size = new Size(40, 40),
                Location = new Point(accountsElement.GroupBox.Width - 60, accountsElement.GroupBox.Height - 60),
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };

            btnToggleAddForm.FlatAppearance.BorderSize = 0;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnToggleAddForm.Width, btnToggleAddForm.Height);
            btnToggleAddForm.Region = new Region(path);

            btnToggleAddForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnToggleAddForm.Click += (s, e) => pnlAddAccount.Visible = !pnlAddAccount.Visible;

            accountsElement.GroupBox.Controls.Add(dgvAccounts);
            accountsElement.GroupBox.Controls.Add(pnlAddAccount);
            accountsElement.GroupBox.Controls.Add(btnToggleAddForm);

            AddElements(new List<Element> { accountsElement });
            RefreshDataGrid();

        //}
        //accountsElement.GroupBox.Controls.Add(dgvAccounts);
        //    accountsElement.GroupBox.Controls.Add(btnToggleAddPanel);
        //    accountsElement.GroupBox.Controls.Add(addAccountPanel);

            //    AddElements(new List<Element> { accountsElement });


        }

        private void ToggleAddPanelVisibility(object sender, EventArgs e)
        {
            addAccountPanel.Visible = !addAccountPanel.Visible;
        }

        private void btnAdd_Click(WF.TextBox txtName, WF.TextBox txtBalance)
        {
            string name = txtName.Text.Trim();
            string balanceText = txtBalance.Text.Trim();

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

            txtName.Text = "";
            txtBalance.Text = "";

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dgvAccounts.Rows.Clear();
            var accounts = MainForm.AppState.UserManager.LoggedUser?.Accounts;
            if (accounts != null)
            {
                foreach (var acc in accounts)
                {
                    dgvAccounts.Rows.Add(acc.Name, acc.Balance.ToString("F2"));
                }
            }
        }
    }
}

