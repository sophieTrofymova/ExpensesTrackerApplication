namespace ExpenseTracker.Elements
{
    partial class AddBudgetElement
    {
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
        private void InitializeComponent()
        {
            bAddBudget = new ExpenseTracker.Controls.ThemedButton();
            bCancelAddBudget = new ExpenseTracker.Controls.ThemedButton();
            tbLimitAmount = new ExpenseTracker.Controls.ThemedTextBox();
            label6 = new ExpenseTracker.Controls.ThemedLabel();
            bCategory = new ExpenseTracker.Controls.ThemedLabel();
            cbUserAccountsAddBudget = new ExpenseTracker.Controls.ThemedComboBox();
            label7 = new ExpenseTracker.Controls.ThemedLabel();
            addBudgetCategoryDropDown = new ExpenseTracker.Controls.ThemedComboBox();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(bAddBudget);
            ThemedGroupBox.Controls.Add(bCancelAddBudget);
            ThemedGroupBox.Controls.Add(tbLimitAmount);
            ThemedGroupBox.Controls.Add(label6);
            ThemedGroupBox.Controls.Add(bCategory);
            ThemedGroupBox.Controls.Add(cbUserAccountsAddBudget);
            ThemedGroupBox.Controls.Add(label7);
            ThemedGroupBox.Controls.Add(addBudgetCategoryDropDown);
            ThemedGroupBox.Size = new Size(754, 704);
            // 
            // bAddBudget
            // 
            bAddBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAddBudget.FlatAppearance.BorderSize = 0;
            bAddBudget.FlatStyle = FlatStyle.Flat;
            bAddBudget.Location = new Point(296, 402);
            bAddBudget.Name = "bAddBudget";
            bAddBudget.Size = new Size(130, 39);
            bAddBudget.TabIndex = 16;
            bAddBudget.Text = "Add";
            bAddBudget.UseVisualStyleBackColor = true;
            bAddBudget.Click += bAddBudget_Click;
            // 
            // bCancelAddBudget
            // 
            bCancelAddBudget.FlatAppearance.BorderSize = 0;
            bCancelAddBudget.FlatStyle = FlatStyle.Flat;
            bCancelAddBudget.Location = new Point(41, 402);
            bCancelAddBudget.Name = "bCancelAddBudget";
            bCancelAddBudget.Size = new Size(132, 39);
            bCancelAddBudget.TabIndex = 17;
            bCancelAddBudget.Text = "Cancel";
            bCancelAddBudget.UseVisualStyleBackColor = true;
            bCancelAddBudget.Click += bCancelAddBudget_Click;
            // 
            // tbLimitAmount
            // 
            tbLimitAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLimitAmount.AutoCompleteMode = AutoCompleteMode.None;
            tbLimitAmount.AutoCompleteSource = AutoCompleteSource.None;
            tbLimitAmount.AutoSize = true;
            tbLimitAmount.BorderThickness = 1;
            tbLimitAmount.CharacterCasing = CharacterCasing.Normal;
            tbLimitAmount.InnerPadding = new Padding(4);
            tbLimitAmount.Location = new Point(44, 307);
            tbLimitAmount.Name = "tbLimitAmount";
            tbLimitAmount.Size = new Size(383, 39);
            tbLimitAmount.TabIndex = 15;
            tbLimitAmount.TextAlign = HorizontalAlignment.Left;
            tbLimitAmount.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(41, 276);
            label6.Name = "label6";
            label6.Size = new Size(135, 28);
            label6.TabIndex = 11;
            label6.Text = "Limit Amount:";
            label6.Click += label6_Click;
            // 
            // bCategory
            // 
            bCategory.AutoSize = true;
            bCategory.Font = new Font("Segoe UI", 12F);
            bCategory.Location = new Point(44, 103);
            bCategory.Name = "bCategory";
            bCategory.Size = new Size(96, 28);
            bCategory.TabIndex = 12;
            bCategory.Text = "Category:";
            // 
            // cbUserAccountsAddBudget
            // 
            cbUserAccountsAddBudget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbUserAccountsAddBudget.BackColor = SystemColors.WindowFrame;
            cbUserAccountsAddBudget.DrawMode = DrawMode.OwnerDrawFixed;
            cbUserAccountsAddBudget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserAccountsAddBudget.ForeColor = Color.WhiteSmoke;
            cbUserAccountsAddBudget.FormattingEnabled = true;
            cbUserAccountsAddBudget.Location = new Point(44, 220);
            cbUserAccountsAddBudget.Name = "cbUserAccountsAddBudget";
            cbUserAccountsAddBudget.Size = new Size(382, 40);
            cbUserAccountsAddBudget.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(44, 189);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 13;
            label7.Text = "Account:";
            // 
            // addBudgetCategoryDropDown
            // 
            addBudgetCategoryDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addBudgetCategoryDropDown.BackColor = SystemColors.WindowFrame;
            addBudgetCategoryDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            addBudgetCategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            addBudgetCategoryDropDown.ForeColor = Color.WhiteSmoke;
            addBudgetCategoryDropDown.FormattingEnabled = true;
            addBudgetCategoryDropDown.Location = new Point(44, 134);
            addBudgetCategoryDropDown.Name = "addBudgetCategoryDropDown";
            addBudgetCategoryDropDown.Size = new Size(382, 40);
            addBudgetCategoryDropDown.TabIndex = 9;
            // 
            // AddBudgetElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "AddBudgetElement";
            Size = new Size(764, 754);
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ThemedButton bAddBudget;
        private Controls.ThemedButton bCancelAddBudget;
        private Controls.ThemedTextBox tbLimitAmount;
        private Controls.ThemedLabel label6;
        private Controls.ThemedLabel bCategory;
        public Controls.ThemedComboBox cbUserAccountsAddBudget;
        private Controls.ThemedLabel label7;
        public Controls.ThemedComboBox addBudgetCategoryDropDown;
    }
}
