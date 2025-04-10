using ExpenseTracker.Controls;

namespace ExpenseTracker.Elements
{
    partial class ViewAccountsElement {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            bAddAccount = new ThemedButton();
            bEditAccount = new ThemedButton();
            tbDeleteAccount = new ThemedButton();
            lvAccounts = new ListView();
            Account = new ColumnHeader();
            Balance = new ColumnHeader();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(lvAccounts);
            ThemedGroupBox.Controls.Add(tbDeleteAccount);
            ThemedGroupBox.Controls.Add(bEditAccount);
            ThemedGroupBox.Controls.Add(bAddAccount);
            ThemedGroupBox.Size = new Size(978, 604);
            // 
            // bAddAccount
            // 
            bAddAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAddAccount.FlatAppearance.BorderSize = 0;
            bAddAccount.FlatStyle = FlatStyle.Flat;
            bAddAccount.Location = new Point(587, 45);
            bAddAccount.Name = "bAddAccount";
            bAddAccount.Size = new Size(169, 44);
            bAddAccount.TabIndex = 1;
            bAddAccount.TabStop = false;
            bAddAccount.Text = "Add Account";
            bAddAccount.UseVisualStyleBackColor = true;
            bAddAccount.Click += bAddAccount_Click;
            // 
            // bEditAccount
            // 
            bEditAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEditAccount.FlatAppearance.BorderSize = 0;
            bEditAccount.FlatStyle = FlatStyle.Flat;
            bEditAccount.Location = new Point(412, 45);
            bEditAccount.Name = "bEditAccount";
            bEditAccount.Size = new Size(169, 44);
            bEditAccount.TabIndex = 1;
            bEditAccount.Text = "Edit Account";
            bEditAccount.UseVisualStyleBackColor = true;
            bEditAccount.Click += bEditAccount_Click;
            // 
            // tbDeleteAccount
            // 
            tbDeleteAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbDeleteAccount.FlatAppearance.BorderSize = 0;
            tbDeleteAccount.FlatStyle = FlatStyle.Flat;
            tbDeleteAccount.Location = new Point(762, 45);
            tbDeleteAccount.Name = "tbDeleteAccount";
            tbDeleteAccount.Size = new Size(191, 44);
            tbDeleteAccount.TabIndex = 1;
            tbDeleteAccount.Text = "Delete Account";
            tbDeleteAccount.UseVisualStyleBackColor = true;
            tbDeleteAccount.Click += tbDeleteAccount_Click;
            // 
            // lvAccounts
            // 
            lvAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvAccounts.BackColor = SystemColors.WindowFrame;
            lvAccounts.Columns.AddRange(new ColumnHeader[] { Account, Balance });
            lvAccounts.ForeColor = Color.WhiteSmoke;
            lvAccounts.GridLines = true;
            lvAccounts.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvAccounts.Location = new Point(23, 107);
            lvAccounts.Name = "lvAccounts";
            lvAccounts.Size = new Size(930, 476);
            lvAccounts.TabIndex = 2;
            lvAccounts.UseCompatibleStateImageBehavior = false;
            lvAccounts.View = View.Details;
            // 
            // Account
            // 
            Account.Text = "Account";
            Account.Width = 250;
            // 
            // Balance
            // 
            Balance.Text = "Balance";
            Balance.Width = 250;
            // 
            // ViewAccountsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "ViewAccountsElement";
            Size = new Size(988, 654);
            ThemedGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ThemedButton bAddAccount;
        private ThemedButton bEditAccount;
        private ThemedButton tbDeleteAccount;
        private ListView lvAccounts;
        private ColumnHeader Account;
        private ColumnHeader Balance;
    }
}
