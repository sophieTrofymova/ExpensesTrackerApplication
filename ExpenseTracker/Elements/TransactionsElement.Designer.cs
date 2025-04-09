using ExpenseTracker.Controls;

namespace ExpenseTracker.Elements {
    partial class TransactionsElement: Element {
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
            label1 = new Label();
            monthDropDown = new ThemedComboBox();
            groupBox1 = new ThemedGroupBox();
            bResetFilter = new Button();
            cbTransfers = new ThemedCheckBox();
            cbIncome = new ThemedCheckBox();
            cbExpenses = new ThemedCheckBox();
            accountsDropDown = new ThemedComboBox();
            label5 = new Label();
            categoriesDropDown = new ThemedComboBox();
            label4 = new Label();
            groupBox2 = new ThemedGroupBox();
            tbExpenseAmount = new ThemedTextBox();
            bAddExpense = new Button();
            dtpAffectDate = new DateTimePicker();
            label6 = new Label();
            cbUserAccounts = new ThemedComboBox();
            label7 = new Label();
            label3 = new Label();
            bCategory = new Label();
            label2 = new Label();
            cbTransactionType = new ThemedComboBox();
            newTransactionCategoryDropDown = new ThemedComboBox();
            groupBox4 = new ThemedGroupBox();
            transactionsList = new ListView();
            chDate = new ColumnHeader();
            chCategory = new ColumnHeader();
            chAmount = new ColumnHeader();
            ThemedGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(groupBox1);
            ThemedGroupBox.Controls.Add(groupBox4);
            ThemedGroupBox.Controls.Add(groupBox2);
            ThemedGroupBox.Size = new Size(1293, 758);
            ThemedGroupBox.Text = "Transactions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(466, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 3;
            label1.Text = "Month:";
            // 
            // monthDropDown
            // 
            monthDropDown.BackColor = SystemColors.WindowFrame;
            monthDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            monthDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            monthDropDown.ForeColor = Color.WhiteSmoke;
            monthDropDown.FormattingEnabled = true;
            monthDropDown.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthDropDown.Location = new Point(466, 70);
            monthDropDown.Name = "monthDropDown";
            monthDropDown.Size = new Size(197, 40);
            monthDropDown.TabIndex = 2;
            monthDropDown.SelectedIndexChanged += monthDropDown_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BorderPadding = 8;
            groupBox1.Controls.Add(bResetFilter);
            groupBox1.Controls.Add(cbTransfers);
            groupBox1.Controls.Add(cbIncome);
            groupBox1.Controls.Add(cbExpenses);
            groupBox1.Controls.Add(accountsDropDown);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(categoriesDropDown);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(monthDropDown);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(23, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1250, 180);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // bResetFilter
            // 
            bResetFilter.FlatStyle = FlatStyle.Flat;
            bResetFilter.Font = new Font("Segoe UI", 12F);
            bResetFilter.Location = new Point(1074, 39);
            bResetFilter.Name = "bResetFilter";
            bResetFilter.Size = new Size(135, 42);
            bResetFilter.TabIndex = 5;
            bResetFilter.Text = "Reset Filter";
            bResetFilter.UseVisualStyleBackColor = true;
            bResetFilter.Click += bResetFilter_Click;
            // 
            // cbTransfers
            // 
            cbTransfers.AutoSize = true;
            cbTransfers.CheckBoxSize = 24;
            cbTransfers.Checked = true;
            cbTransfers.CheckState = CheckState.Checked;
            cbTransfers.Font = new Font("Segoe UI", 12F);
            cbTransfers.Location = new Point(273, 127);
            cbTransfers.Name = "cbTransfers";
            cbTransfers.Size = new Size(101, 32);
            cbTransfers.TabIndex = 4;
            cbTransfers.Text = "Transfer";
            cbTransfers.UseVisualStyleBackColor = true;
            cbTransfers.CheckedChanged += cbTransfers_CheckedChanged;
            // 
            // cbIncome
            // 
            cbIncome.AutoSize = true;
            cbIncome.CheckBoxSize = 24;
            cbIncome.Checked = true;
            cbIncome.CheckState = CheckState.Checked;
            cbIncome.Font = new Font("Segoe UI", 12F);
            cbIncome.Location = new Point(158, 127);
            cbIncome.Name = "cbIncome";
            cbIncome.Size = new Size(98, 32);
            cbIncome.TabIndex = 4;
            cbIncome.Text = "Income";
            cbIncome.UseVisualStyleBackColor = true;
            cbIncome.CheckedChanged += cbIncome_CheckedChanged;
            // 
            // cbExpenses
            // 
            cbExpenses.AutoSize = true;
            cbExpenses.CheckBoxSize = 24;
            cbExpenses.Checked = true;
            cbExpenses.CheckState = CheckState.Checked;
            cbExpenses.Font = new Font("Segoe UI", 12F);
            cbExpenses.Location = new Point(28, 127);
            cbExpenses.Name = "cbExpenses";
            cbExpenses.Size = new Size(112, 32);
            cbExpenses.TabIndex = 4;
            cbExpenses.Text = "Expenses";
            cbExpenses.UseVisualStyleBackColor = true;
            cbExpenses.CheckedChanged += cbExpenses_CheckedChanged;
            // 
            // accountsDropDown
            // 
            accountsDropDown.BackColor = SystemColors.WindowFrame;
            accountsDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            accountsDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            accountsDropDown.ForeColor = Color.WhiteSmoke;
            accountsDropDown.FormattingEnabled = true;
            accountsDropDown.Location = new Point(247, 71);
            accountsDropDown.Name = "accountsDropDown";
            accountsDropDown.Size = new Size(197, 40);
            accountsDropDown.TabIndex = 2;
            accountsDropDown.SelectedIndexChanged += accountsDropDown_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(247, 40);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 3;
            label5.Text = "Account:";
            label5.Click += label5_Click;
            // 
            // categoriesDropDown
            // 
            categoriesDropDown.BackColor = SystemColors.WindowFrame;
            categoriesDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            categoriesDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriesDropDown.ForeColor = Color.WhiteSmoke;
            categoriesDropDown.FormattingEnabled = true;
            categoriesDropDown.Location = new Point(28, 71);
            categoriesDropDown.Name = "categoriesDropDown";
            categoriesDropDown.Size = new Size(197, 40);
            categoriesDropDown.TabIndex = 2;
            categoriesDropDown.SelectedIndexChanged += categoriesDropDown_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(27, 40);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // groupBox2
            // 
            groupBox2.BorderPadding = 8;
            groupBox2.Controls.Add(tbExpenseAmount);
            groupBox2.Controls.Add(bAddExpense);
            groupBox2.Controls.Add(dtpAffectDate);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbUserAccounts);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(bCategory);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbTransactionType);
            groupBox2.Controls.Add(newTransactionCategoryDropDown);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(23, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 511);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Transaction";
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
            tbExpenseAmount.Location = new Point(40, 297);
            tbExpenseAmount.Name = "tbExpenseAmount";
            tbExpenseAmount.Size = new Size(223, 39);
            tbExpenseAmount.TabIndex = 6;
            tbExpenseAmount.TextAlign = HorizontalAlignment.Left;
            tbExpenseAmount.UseSystemPasswordChar = false;
            // 
            // bAddExpense
            // 
            bAddExpense.FlatStyle = FlatStyle.Flat;
            bAddExpense.Font = new Font("Segoe UI", 12F);
            bAddExpense.Location = new Point(214, 421);
            bAddExpense.Name = "bAddExpense";
            bAddExpense.Size = new Size(114, 40);
            bAddExpense.TabIndex = 5;
            bAddExpense.Text = "Add";
            bAddExpense.UseVisualStyleBackColor = true;
            bAddExpense.Click += bAddExpense_Click;
            // 
            // dtpAffectDate
            // 
            dtpAffectDate.CustomFormat = "dd/MM/yyyy";
            dtpAffectDate.Font = new Font("Segoe UI", 12F);
            dtpAffectDate.Format = DateTimePickerFormat.Custom;
            dtpAffectDate.Location = new Point(40, 370);
            dtpAffectDate.Name = "dtpAffectDate";
            dtpAffectDate.Size = new Size(289, 34);
            dtpAffectDate.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 266);
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
            cbUserAccounts.Location = new Point(40, 151);
            cbUserAccounts.Name = "cbUserAccounts";
            cbUserAccounts.Size = new Size(289, 40);
            cbUserAccounts.TabIndex = 2;
            cbUserAccounts.SelectedIndexChanged += accountsDropDown_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(22, 120);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 3;
            label7.Text = "Account:";
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 38);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 3;
            label3.Text = "Type:";
            // 
            // bCategory
            // 
            bCategory.AutoSize = true;
            bCategory.Font = new Font("Segoe UI", 12F);
            bCategory.Location = new Point(22, 193);
            bCategory.Name = "bCategory";
            bCategory.Size = new Size(96, 28);
            bCategory.TabIndex = 3;
            bCategory.Text = "Category:";
            bCategory.Click += bCategory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 339);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 3;
            label2.Text = "Affect Date:";
            label2.Click += label2_Click;
            // 
            // cbTransactionType
            // 
            cbTransactionType.BackColor = SystemColors.WindowFrame;
            cbTransactionType.DrawMode = DrawMode.OwnerDrawFixed;
            cbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTransactionType.ForeColor = Color.WhiteSmoke;
            cbTransactionType.FormattingEnabled = true;
            cbTransactionType.Location = new Point(40, 78);
            cbTransactionType.Name = "cbTransactionType";
            cbTransactionType.Size = new Size(289, 40);
            cbTransactionType.TabIndex = 2;
            cbTransactionType.SelectedIndexChanged += cbTransactionType_SelectedIndexChanged;
            // 
            // newTransactionCategoryDropDown
            // 
            newTransactionCategoryDropDown.BackColor = SystemColors.WindowFrame;
            newTransactionCategoryDropDown.DrawMode = DrawMode.OwnerDrawFixed;
            newTransactionCategoryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            newTransactionCategoryDropDown.ForeColor = Color.WhiteSmoke;
            newTransactionCategoryDropDown.FormattingEnabled = true;
            newTransactionCategoryDropDown.Location = new Point(40, 224);
            newTransactionCategoryDropDown.Name = "newTransactionCategoryDropDown";
            newTransactionCategoryDropDown.Size = new Size(289, 40);
            newTransactionCategoryDropDown.TabIndex = 2;
            newTransactionCategoryDropDown.SelectedIndexChanged += categoriesDropDown_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BorderPadding = 8;
            groupBox4.Controls.Add(transactionsList);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(376, 233);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(897, 511);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Transactions";
            // 
            // transactionsList
            // 
            transactionsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactionsList.BackColor = SystemColors.WindowFrame;
            transactionsList.Columns.AddRange(new ColumnHeader[] { chDate, chCategory, chAmount });
            transactionsList.ForeColor = Color.WhiteSmoke;
            transactionsList.FullRowSelect = true;
            transactionsList.GridLines = true;
            transactionsList.Location = new Point(24, 45);
            transactionsList.Name = "transactionsList";
            transactionsList.Size = new Size(853, 442);
            transactionsList.TabIndex = 0;
            transactionsList.UseCompatibleStateImageBehavior = false;
            transactionsList.View = View.Details;
            // 
            // chDate
            // 
            chDate.Text = "Date";
            // 
            // chCategory
            // 
            chCategory.Text = "Category";
            // 
            // chAmount
            // 
            chAmount.Text = "Amount";
            // 
            // TransactionsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "TransactionsElement";
            Size = new Size(1306, 808);
            Title = "Transactions";
            ThemedGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ThemedGroupBox groupBox1;
        public ThemedComboBox monthDropDown;
        private Label label1;
        private ThemedGroupBox groupBox4;
        private ThemedGroupBox groupBox2;
        private Label label2;
        public ThemedComboBox categoriesDropDown;
        private Label label4;
        public ThemedComboBox accountsDropDown;
        private Label label5;
        public ListView transactionsList;
        private ColumnHeader chDate;
        private ColumnHeader chCategory;
        private ColumnHeader chAmount;
        private ThemedCheckBox cbIncome;
        private ThemedCheckBox cbExpenses;
        private ThemedCheckBox cbTransfers;
        private Button bResetFilter;
        private Button bAddExpense;
        private DateTimePicker dtpAffectDate;
        private Label bCategory;
        private ThemedTextBox tbExpenseAmount;
        private Label label6;
        public ThemedComboBox newTransactionCategoryDropDown;
        public ThemedComboBox cbUserAccounts;
        private Label label7;
        private Label label3;
        public ThemedComboBox cbTransactionType;
    }
}
