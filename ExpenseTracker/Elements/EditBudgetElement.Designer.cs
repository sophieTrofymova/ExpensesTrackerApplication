namespace ExpenseTracker.Elements
{
    partial class EditBudgetElement
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
            bAEditBudget = new ExpenseTracker.Controls.ThemedButton();
            bCancelEditBudget = new ExpenseTracker.Controls.ThemedButton();
            tbLimitAmountEdit = new ExpenseTracker.Controls.ThemedTextBox();
            label6 = new ExpenseTracker.Controls.ThemedLabel();
            bCategory = new ExpenseTracker.Controls.ThemedLabel();
            cbUserAccountsEditBudget = new ExpenseTracker.Controls.ThemedComboBox();
            label7 = new ExpenseTracker.Controls.ThemedLabel();
            editBudgetCategoryDropDown = new ExpenseTracker.Controls.ThemedComboBox();
            ThemedGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(bAEditBudget);
            ThemedGroupBox.Controls.Add(bCategory);
            ThemedGroupBox.Controls.Add(bCancelEditBudget);
            ThemedGroupBox.Controls.Add(editBudgetCategoryDropDown);
            ThemedGroupBox.Controls.Add(tbLimitAmountEdit);
            ThemedGroupBox.Controls.Add(label7);
            ThemedGroupBox.Controls.Add(label6);
            ThemedGroupBox.Controls.Add(cbUserAccountsEditBudget);
            ThemedGroupBox.Size = new Size(605, 626);
            // 
            // bAEditBudget
            // 
            bAEditBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAEditBudget.FlatAppearance.BorderSize = 0;
            bAEditBudget.FlatStyle = FlatStyle.Flat;
            bAEditBudget.Location = new Point(337, 398);
            bAEditBudget.Name = "bAEditBudget";
            bAEditBudget.Size = new Size(130, 39);
            bAEditBudget.TabIndex = 24;
            bAEditBudget.Text = "Save";
            bAEditBudget.UseVisualStyleBackColor = true;
            bAEditBudget.Click += bAEditBudget_Click;
            // 
            // bCancelEditBudget
            // 
            bCancelEditBudget.FlatAppearance.BorderSize = 0;
            bCancelEditBudget.FlatStyle = FlatStyle.Flat;
            bCancelEditBudget.Location = new Point(48, 398);
            bCancelEditBudget.Name = "bCancelEditBudget";
            bCancelEditBudget.Size = new Size(132, 39);
            bCancelEditBudget.TabIndex = 25;
            bCancelEditBudget.Text = "Cancel";
            bCancelEditBudget.UseVisualStyleBackColor = true;
            bCancelEditBudget.Click += bCancelEditBudget_Click;
            // 
            // tbLimitAmountEdit
            // 
            tbLimitAmountEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLimitAmountEdit.AutoCompleteMode = AutoCompleteMode.None;
            tbLimitAmountEdit.AutoCompleteSource = AutoCompleteSource.None;
            tbLimitAmountEdit.AutoSize = true;
            tbLimitAmountEdit.BorderThickness = 1;
            tbLimitAmountEdit.CharacterCasing = CharacterCasing.Normal;
            tbLimitAmountEdit.InnerPadding = new Padding(4);
            tbLimitAmountEdit.Location = new Point(51, 303);
            tbLimitAmountEdit.Name = "tbLimitAmountEdit";
            tbLimitAmountEdit.Size = new Size(421, 39);
            tbLimitAmountEdit.TabIndex = 23;
            tbLimitAmountEdit.TextAlign = HorizontalAlignment.Left;
            tbLimitAmountEdit.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(48, 272);
            label6.Name = "label6";
            label6.Size = new Size(135, 28);
            label6.TabIndex = 20;
            label6.Text = "Limit Amount:";
            // 
            // bCategory
            // 
            bCategory.AutoSize = true;
            bCategory.Font = new Font("Segoe UI", 12F);
            bCategory.Location = new Point(51, 99);
            bCategory.Name = "bCategory";
            bCategory.Size = new Size(96, 28);
            bCategory.TabIndex = 21;
            bCategory.Text = "Category:";
            // 
            // cbUserAccountsEditBudget
            // 
            cbUserAccountsEditBudget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbUserAccountsEditBudget.BackColor = SystemColors.WindowFrame;
            cbUserAccountsEditBudget.DrawMode = DrawMode.OwnerDrawFixed;
            cbUserAccountsEditBudget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserAccountsEditBudget.ForeColor = Color.WhiteSmoke;
            cbUserAccountsEditBudget.FormattingEnabled = true;
            cbUserAccountsEditBudget.Location = new Point(51, 216);
            cbUserAccountsEditBudget.Name = "cbUserAccountsEditBudget";
            cbUserAccountsEditBudget.Size = new Size(416, 40);
            cbUserAccountsEditBudget.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(51, 185);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 22;
            label7.Text = "Account:";
            // 
            // editBudgetCategoryDropDown
            // 
            editBudgetCategoryDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editBudgetCategoryDropDown.BackColor = SystemColors.WindowFrame;
            editBudgetCategoryDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            editBudgetCategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            editBudgetCategoryDropDown.ForeColor = Color.WhiteSmoke;
            editBudgetCategoryDropDown.FormattingEnabled = true;
            editBudgetCategoryDropDown.Location = new Point(51, 130);
            editBudgetCategoryDropDown.Name = "editBudgetCategoryDropDown";
            editBudgetCategoryDropDown.Size = new Size(416, 40);
            editBudgetCategoryDropDown.TabIndex = 19;
            // 
            // EditBudgetElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "EditBudgetElement";
            Size = new Size(615, 676);
            ThemedGroupBox.ResumeLayout(false);
            ThemedGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ThemedButton bAEditBudget;
        private Controls.ThemedLabel bCategory;
        private Controls.ThemedButton bCancelEditBudget;
        public Controls.ThemedComboBox editBudgetCategoryDropDown;
        private Controls.ThemedTextBox tbLimitAmountEdit;
        private Controls.ThemedLabel label7;
        private Controls.ThemedLabel label6;
        public Controls.ThemedComboBox cbUserAccountsEditBudget;
    }
}
