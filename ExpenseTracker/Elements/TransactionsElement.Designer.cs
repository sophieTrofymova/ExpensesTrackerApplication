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
            label1 = new ThemedLabel();
            monthDropDown = new ThemedComboBox();
            groupBox1 = new ThemedGroupBox();
            bResetFilter = new ThemedButton();
            cbTransfers = new ThemedCheckBox();
            cbIncome = new ThemedCheckBox();
            cbExpenses = new ThemedCheckBox();
            accountsDropDown = new ThemedComboBox();
            label5 = new ThemedLabel();
            categoriesDropDown = new ThemedComboBox();
            label4 = new ThemedLabel();
            comboBox3 = new ThemedComboBox();
            comboBox4 = new ThemedComboBox();
            groupBox4 = new ThemedGroupBox();
            bAddTransfer = new ThemedButton();
            bAddIncome = new ThemedButton();
            bAddExpense = new ThemedButton();
            transactionsList = new ListView();
            chDate = new ColumnHeader();
            chCategory = new ColumnHeader();
            chAmount = new ColumnHeader();
            themedButton2 = new ThemedButton();
            themedButton1 = new ThemedButton();
            ThemedGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // ThemedGroupBox
            // 
            ThemedGroupBox.Controls.Add(groupBox1);
            ThemedGroupBox.Controls.Add(groupBox4);
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
            bResetFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bResetFilter.FlatAppearance.BorderSize = 0;
            bResetFilter.FlatStyle = FlatStyle.Flat;
            bResetFilter.Location = new Point(1082, 43);
            bResetFilter.Name = "bResetFilter";
            bResetFilter.Size = new Size(148, 40);
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
            label4.Location = new Point(28, 40);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.WindowFrame;
            comboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox3.Location = new Point(296, 70);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(197, 28);
            comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = SystemColors.WindowFrame;
            comboBox4.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox4.Location = new Point(610, 70);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(197, 28);
            comboBox4.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.BorderPadding = 8;
            groupBox4.Controls.Add(bAddTransfer);
            groupBox4.Controls.Add(bAddIncome);
            groupBox4.Controls.Add(bAddExpense);
            groupBox4.Controls.Add(transactionsList);
            groupBox4.Controls.Add(themedButton2);
            groupBox4.Controls.Add(themedButton1);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(23, 233);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1250, 511);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Transactions";
            // 
            // bAddTransfer
            // 
            bAddTransfer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAddTransfer.FlatAppearance.BorderSize = 0;
            bAddTransfer.FlatStyle = FlatStyle.Flat;
            bAddTransfer.Font = new Font("Segoe UI", 12F);
            bAddTransfer.Location = new Point(890, 43);
            bAddTransfer.Name = "bAddTransfer";
            bAddTransfer.Size = new Size(139, 40);
            bAddTransfer.TabIndex = 5;
            bAddTransfer.Text = "Add Transfer";
            bAddTransfer.UseVisualStyleBackColor = true;
            bAddTransfer.Click += bAddTransfer_Click;
            // 
            // bAddIncome
            // 
            bAddIncome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAddIncome.FlatAppearance.BorderSize = 0;
            bAddIncome.FlatStyle = FlatStyle.Flat;
            bAddIncome.Font = new Font("Segoe UI", 12F);
            bAddIncome.Location = new Point(745, 43);
            bAddIncome.Name = "bAddIncome";
            bAddIncome.Size = new Size(139, 40);
            bAddIncome.TabIndex = 5;
            bAddIncome.Text = "Add Income";
            bAddIncome.UseVisualStyleBackColor = true;
            bAddIncome.Click += bAddIncome_Click;
            // 
            // bAddExpense
            // 
            bAddExpense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAddExpense.FlatAppearance.BorderSize = 0;
            bAddExpense.FlatStyle = FlatStyle.Flat;
            bAddExpense.Font = new Font("Segoe UI", 12F);
            bAddExpense.Location = new Point(585, 43);
            bAddExpense.Name = "bAddExpense";
            bAddExpense.Size = new Size(154, 40);
            bAddExpense.TabIndex = 5;
            bAddExpense.Text = "Add Expense";
            bAddExpense.UseVisualStyleBackColor = true;
            bAddExpense.Click += bAddExpense_Click;
            // 
            // transactionsList
            // 
            transactionsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactionsList.BackColor = SystemColors.WindowFrame;
            transactionsList.Columns.AddRange(new ColumnHeader[] { chDate, chCategory, chAmount });
            transactionsList.ForeColor = Color.WhiteSmoke;
            transactionsList.FullRowSelect = true;
            transactionsList.GridLines = true;
            transactionsList.Location = new Point(24, 93);
            transactionsList.Name = "transactionsList";
            transactionsList.Size = new Size(1206, 394);
            transactionsList.TabIndex = 0;
            transactionsList.UseCompatibleStateImageBehavior = false;
            transactionsList.View = View.Details;
            // 
            // chDate
            // 
            chDate.Text = "Date";
            chDate.Width = 100;
            // 
            // chCategory
            // 
            chCategory.Text = "Category";
            chCategory.Width = 150;
            // 
            // chAmount
            // 
            chAmount.Text = "Amount";
            chAmount.Width = 150;
            // 
            // themedButton2
            // 
            themedButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            themedButton2.FlatAppearance.BorderSize = 0;
            themedButton2.FlatStyle = FlatStyle.Flat;
            themedButton2.Font = new Font("Segoe UI", 12F);
            themedButton2.Location = new Point(1046, 43);
            themedButton2.Name = "themedButton2";
            themedButton2.Size = new Size(89, 40);
            themedButton2.TabIndex = 5;
            themedButton2.Text = "Delete";
            themedButton2.UseVisualStyleBackColor = true;
            // 
            // themedButton1
            // 
            themedButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            themedButton1.FlatAppearance.BorderSize = 0;
            themedButton1.FlatStyle = FlatStyle.Flat;
            themedButton1.Font = new Font("Segoe UI", 12F);
            themedButton1.Location = new Point(1141, 43);
            themedButton1.Name = "themedButton1";
            themedButton1.Size = new Size(89, 40);
            themedButton1.TabIndex = 5;
            themedButton1.Text = "Edit";
            themedButton1.UseVisualStyleBackColor = true;
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
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private ThemedGroupBox groupBox1;
        public ThemedComboBox monthDropDown;
        private ThemedLabel label1;
        private ThemedGroupBox groupBox4;
        public ThemedComboBox comboBox3;
        public ThemedComboBox comboBox4;
        public ThemedComboBox categoriesDropDown;
        private ThemedLabel label4;
        public ThemedComboBox accountsDropDown;
        private ThemedLabel label5;
        public ListView transactionsList;
        private ColumnHeader chDate;
        private ColumnHeader chCategory;
        private ColumnHeader chAmount;
        private ThemedCheckBox cbIncome;
        private ThemedCheckBox cbExpenses;
        private ThemedCheckBox cbTransfers;
        private ThemedButton bResetFilter;
        private ThemedButton bAddExpense;
        private ThemedButton themedButton2;
        private ThemedButton themedButton1;
        private ThemedButton bAddTransfer;
        private ThemedButton bAddIncome;
    }
}
