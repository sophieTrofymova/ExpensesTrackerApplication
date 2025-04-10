﻿namespace ExpenseTracker.Elements {
    partial class AddTransactionElement {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            tbExpenseAmount = new Controls.ThemedTextBox();
            dtpAffectDate = new DateTimePicker();
            label6 = new Controls.ThemedLabel();
            cbUserAccounts = new Controls.ThemedComboBox();
            label7 = new Controls.ThemedLabel();
            bCategory = new Controls.ThemedLabel();
            label2 = new Controls.ThemedLabel();
            newTransactionCategoryDropDown = new Controls.ThemedComboBox();
            bCancel = new Controls.ThemedButton();
            bAdd = new Controls.ThemedButton();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(bAdd);
            ThemedGroupBox.Controls.Add(bCancel);
            ThemedGroupBox.Controls.Add(dtpAffectDate);
            ThemedGroupBox.Controls.Add(label2);
            ThemedGroupBox.Controls.Add(tbExpenseAmount);
            ThemedGroupBox.Controls.Add(label6);
            ThemedGroupBox.Controls.Add(bCategory);
            ThemedGroupBox.Controls.Add(cbUserAccounts);
            ThemedGroupBox.Controls.Add(label7);
            ThemedGroupBox.Controls.Add(newTransactionCategoryDropDown);
            ThemedGroupBox.Size = new Size(687, 443);
            // 
            // tbExpenseAmount
            // 
            tbExpenseAmount.AutoCompleteMode = AutoCompleteMode.None;
            tbExpenseAmount.AutoCompleteSource = AutoCompleteSource.None;
            tbExpenseAmount.AutoSize = true;
            tbExpenseAmount.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbExpenseAmount.BorderThickness = 1;
            tbExpenseAmount.CharacterCasing = CharacterCasing.Normal;
            tbExpenseAmount.InnerPadding = new Padding(4);
            tbExpenseAmount.Location = new Point(365, 85);
            tbExpenseAmount.Name = "tbExpenseAmount";
            tbExpenseAmount.Size = new Size(216, 39);
            tbExpenseAmount.TabIndex = 6;
            tbExpenseAmount.TextAlign = HorizontalAlignment.Left;
            tbExpenseAmount.UseSystemPasswordChar = false;
            // 
            // dtpAffectDate
            // 
            dtpAffectDate.CustomFormat = "dd/MM/yyyy";
            dtpAffectDate.Font = new Font("Segoe UI", 12F);
            dtpAffectDate.Format = DateTimePickerFormat.Custom;
            dtpAffectDate.Location = new Point(36, 290);
            dtpAffectDate.Name = "dtpAffectDate";
            dtpAffectDate.Size = new Size(289, 34);
            dtpAffectDate.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(365, 54);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 3;
            label6.Text = "Amount:";
            // 
            // cbUserAccounts
            // 
            cbUserAccounts.BackColor = SystemColors.WindowFrame;
            cbUserAccounts.DrawMode = DrawMode.OwnerDrawFixed;
            cbUserAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserAccounts.ForeColor = Color.WhiteSmoke;
            cbUserAccounts.FormattingEnabled = true;
            cbUserAccounts.Location = new Point(36, 179);
            cbUserAccounts.Name = "cbUserAccounts";
            cbUserAccounts.Size = new Size(287, 40);
            cbUserAccounts.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(36, 148);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 3;
            label7.Text = "Account:";
            // 
            // bCategory
            // 
            bCategory.AutoSize = true;
            bCategory.Font = new Font("Segoe UI", 12F);
            bCategory.Location = new Point(36, 54);
            bCategory.Name = "bCategory";
            bCategory.Size = new Size(96, 28);
            bCategory.TabIndex = 3;
            bCategory.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 244);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 3;
            label2.Text = "Affect Date:";
            // 
            // newTransactionCategoryDropDown
            // 
            newTransactionCategoryDropDown.BackColor = SystemColors.WindowFrame;
            newTransactionCategoryDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            newTransactionCategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            newTransactionCategoryDropDown.ForeColor = Color.WhiteSmoke;
            newTransactionCategoryDropDown.FormattingEnabled = true;
            newTransactionCategoryDropDown.Location = new Point(36, 85);
            newTransactionCategoryDropDown.Name = "newTransactionCategoryDropDown";
            newTransactionCategoryDropDown.Size = new Size(287, 40);
            newTransactionCategoryDropDown.TabIndex = 2;
            // 
            // bCancel
            // 
            bCancel.FlatAppearance.BorderSize = 0;
            bCancel.FlatStyle = FlatStyle.Flat;
            bCancel.Location = new Point(50, 362);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(115, 45);
            bCancel.TabIndex = 7;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // bAdd
            // 
            bAdd.FlatAppearance.BorderSize = 0;
            bAdd.FlatStyle = FlatStyle.Flat;
            bAdd.Location = new Point(186, 362);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(115, 45);
            bAdd.TabIndex = 7;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // AddTransactionElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "AddTransactionElement";
            Size = new Size(697, 493);
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpAffectDate;
        private Controls.ThemedLabel label2;
        private Controls.ThemedTextBox tbExpenseAmount;
        private Controls.ThemedLabel label6;
        private Controls.ThemedLabel bCategory;
        public Controls.ThemedComboBox cbUserAccounts;
        private Controls.ThemedLabel label7;
        public Controls.ThemedComboBox newTransactionCategoryDropDown;
        private Controls.ThemedButton bAdd;
        private Controls.ThemedButton bCancel;
    }
}
