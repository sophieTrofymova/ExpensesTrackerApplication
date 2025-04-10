using ExpenseTracker.Controls;

namespace ExpenseTracker.Elements
{
    partial class AddAccountElement {
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
            txtAccountName = new ThemedTextBox();
            lblName = new ThemedLabel();
            txtInitialBalance = new ThemedTextBox();
            lblBalance = new ThemedLabel();
            btnAdd = new ThemedButton();
            btnCancel = new ThemedButton();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(txtInitialBalance);
            ThemedGroupBox.Controls.Add(btnCancel);
            ThemedGroupBox.Controls.Add(btnAdd);
            ThemedGroupBox.Controls.Add(txtAccountName);
            ThemedGroupBox.Controls.Add(lblName);
            ThemedGroupBox.Controls.Add(lblBalance);
            ThemedGroupBox.Size = new Size(428, 327);
            // 
            // txtAccountName
            // 
            txtAccountName.AutoCompleteMode = AutoCompleteMode.None;
            txtAccountName.AutoCompleteSource = AutoCompleteSource.None;
            txtAccountName.AutoSize = true;
            txtAccountName.BorderThickness = 1;
            txtAccountName.CharacterCasing = CharacterCasing.Normal;
            txtAccountName.InnerPadding = new Padding(4);
            txtAccountName.Location = new Point(64, 95);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(318, 39);
            txtAccountName.TabIndex = 1;
            txtAccountName.TextAlign = HorizontalAlignment.Left;
            txtAccountName.UseSystemPasswordChar = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(34, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(172, 32);
            lblName.TabIndex = 2;
            lblName.Text = "Account Name";
            // 
            // txtInitialBalance
            // 
            txtInitialBalance.AutoCompleteMode = AutoCompleteMode.None;
            txtInitialBalance.AutoCompleteSource = AutoCompleteSource.None;
            txtInitialBalance.AutoSize = true;
            txtInitialBalance.BorderThickness = 1;
            txtInitialBalance.CharacterCasing = CharacterCasing.Normal;
            txtInitialBalance.InnerPadding = new Padding(4);
            txtInitialBalance.Location = new Point(64, 187);
            txtInitialBalance.Name = "txtInitialBalance";
            txtInitialBalance.Size = new Size(318, 39);
            txtInitialBalance.TabIndex = 1;
            txtInitialBalance.TextAlign = HorizontalAlignment.Left;
            txtInitialBalance.UseSystemPasswordChar = false;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(34, 152);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(166, 32);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Initial Balance:";
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(270, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(64, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddAccountElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "AddAccountElement";
            Size = new Size(438, 377);
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ThemedLabel lblBalance;
        private ThemedLabel lblName;
        private ThemedTextBox txtInitialBalance;
        private ThemedTextBox txtAccountName;
        private ThemedButton btnAdd;
        private ThemedButton btnCancel;
    }
}
