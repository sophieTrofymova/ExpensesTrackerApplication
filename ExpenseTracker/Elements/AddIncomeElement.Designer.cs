namespace ExpenseTracker.Elements {
    partial class AddIncomeElement {
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
            tbIncomeAmount = new Controls.ThemedTextBox();
            dtpAffectDate = new DateTimePicker();
            label6 = new Controls.ThemedLabel();
            cbUserAccounts = new Controls.ThemedComboBox();
            label7 = new Controls.ThemedLabel();
            bCategory = new Controls.ThemedLabel();
            label2 = new Controls.ThemedLabel();
            IncomeCategoryDropDown = new Controls.ThemedComboBox();
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
            ThemedGroupBox.Controls.Add(tbIncomeAmount);
            ThemedGroupBox.Controls.Add(label6);
            ThemedGroupBox.Controls.Add(bCategory);
            ThemedGroupBox.Controls.Add(cbUserAccounts);
            ThemedGroupBox.Controls.Add(label7);
            ThemedGroupBox.Controls.Add(IncomeCategoryDropDown);
            ThemedGroupBox.Size = new Size(449, 470);
            // 
            // tbExpenseAmount
            // 
            tbIncomeAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbIncomeAmount.AutoCompleteMode = AutoCompleteMode.None;
            tbIncomeAmount.AutoCompleteSource = AutoCompleteSource.None;
            tbIncomeAmount.AutoSize = true;
            tbIncomeAmount.BorderThickness = 1;
            tbIncomeAmount.CharacterCasing = CharacterCasing.Normal;
            tbIncomeAmount.InnerPadding = new Padding(4);
            tbIncomeAmount.Location = new Point(36, 258);
            tbIncomeAmount.Name = "tbExpenseAmount";
            tbIncomeAmount.Size = new Size(383, 39);
            tbIncomeAmount.TabIndex = 6;
            tbIncomeAmount.TextAlign = HorizontalAlignment.Left;
            tbIncomeAmount.UseSystemPasswordChar = false;
            // 
            // dtpAffectDate
            // 
            dtpAffectDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpAffectDate.CustomFormat = "dd/MM/yyyy";
            dtpAffectDate.Font = new Font("Segoe UI", 12F);
            dtpAffectDate.Format = DateTimePickerFormat.Custom;
            dtpAffectDate.Location = new Point(36, 346);
            dtpAffectDate.Name = "dtpAffectDate";
            dtpAffectDate.Size = new Size(384, 34);
            dtpAffectDate.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(33, 227);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 3;
            label6.Text = "Amount:";
            // 
            // cbUserAccounts
            // 
            cbUserAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbUserAccounts.BackColor = SystemColors.WindowFrame;
            cbUserAccounts.DrawMode = DrawMode.OwnerDrawFixed;
            cbUserAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserAccounts.ForeColor = Color.WhiteSmoke;
            cbUserAccounts.FormattingEnabled = true;
            cbUserAccounts.Location = new Point(36, 171);
            cbUserAccounts.Name = "cbUserAccounts";
            cbUserAccounts.Size = new Size(382, 40);
            cbUserAccounts.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(36, 140);
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
            label2.Location = new Point(33, 315);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 3;
            label2.Text = "Affect Date:";
            // 
            // IncomeCategoryDropDown
            // 
            IncomeCategoryDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IncomeCategoryDropDown.BackColor = SystemColors.WindowFrame;
            IncomeCategoryDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            IncomeCategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            IncomeCategoryDropDown.ForeColor = Color.WhiteSmoke;
            IncomeCategoryDropDown.FormattingEnabled = true;
            IncomeCategoryDropDown.Location = new Point(36, 85);
            IncomeCategoryDropDown.Name = "IncomeCategoryDropDown";
            IncomeCategoryDropDown.Size = new Size(382, 40);
            IncomeCategoryDropDown.TabIndex = 2;
            // 
            // bCancel
            // 
            bCancel.FlatAppearance.BorderSize = 0;
            bCancel.FlatStyle = FlatStyle.Flat;
            bCancel.Location = new Point(36, 398);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(132, 39);
            bCancel.TabIndex = 7;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // bAdd
            // 
            bAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAdd.FlatAppearance.BorderSize = 0;
            bAdd.FlatStyle = FlatStyle.Flat;
            bAdd.Location = new Point(288, 398);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(130, 39);
            bAdd.TabIndex = 7;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // AddIncomeElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "AddIncomeElement";
            Size = new Size(459, 520);
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpAffectDate;
        private Controls.ThemedLabel label2;
        private Controls.ThemedTextBox tbIncomeAmount;
        private Controls.ThemedLabel label6;
        private Controls.ThemedLabel bCategory;
        public Controls.ThemedComboBox cbUserAccounts;
        private Controls.ThemedLabel label7;
        public Controls.ThemedComboBox IncomeCategoryDropDown;
        private Controls.ThemedButton bAdd;
        private Controls.ThemedButton bCancel;
    }
}
