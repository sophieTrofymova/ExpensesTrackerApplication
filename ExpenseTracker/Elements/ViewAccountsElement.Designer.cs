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
            dgvAccounts = new DataGridView();
            bAddAccount = new ThemedButton();
            ThemedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(bAddAccount);
            ThemedGroupBox.Controls.Add(dgvAccounts);
            ThemedGroupBox.Size = new Size(978, 604);
            // 
            // dgvAccounts
            // 
            dgvAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(24, 109);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.Size = new Size(929, 464);
            dgvAccounts.TabIndex = 0;
            // 
            // bAddAccount
            // 
            bAddAccount.FlatAppearance.BorderSize = 0;
            bAddAccount.FlatStyle = FlatStyle.Flat;
            bAddAccount.Location = new Point(784, 59);
            bAddAccount.Name = "bAddAccount";
            bAddAccount.Size = new Size(169, 44);
            bAddAccount.TabIndex = 1;
            bAddAccount.TabStop = false;
            bAddAccount.Text = "Add Account";
            bAddAccount.UseVisualStyleBackColor = true;
            bAddAccount.Click += bAddAccount_Click;
            // 
            // ViewAccountsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "ViewAccountsElement";
            Size = new Size(988, 654);
            ThemedGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAccounts;
        private ThemedButton bAddAccount;
    }
}
