namespace ExpenseTracker
{
    partial class Sanbox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("Account Name");
            ListViewItem listViewItem2 = new ListViewItem("Balance");
            ListViewItem listViewItem3 = new ListViewItem("Currency");
            DASHBOARD = new TabControl();
            tabDashboard = new TabPage();
            tblAccountsSummary2 = new TableLayoutPanel();
            tblAccountsSummary = new TableLayoutPanel();
            groupBox6 = new GroupBox();
            label38 = new Label();
            txtBalance = new Label();
            label40 = new Label();
            txtTotalBalance = new Label();
            label41 = new Label();
            BalanceLabel = new Label();
            label42 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            navDashboard = new Label();
            tabTransactions = new TabPage();
            groupBox4 = new GroupBox();
            btnCancelAddExpense = new Button();
            dropDownCategoryExpense = new ComboBox();
            dropDownAccountAddExpense = new ComboBox();
            btnAddExpense = new Button();
            txtValueAddExpense = new TextBox();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            groupBox3 = new GroupBox();
            btnCancelAddIncome = new Button();
            dropDownAccountAddIncome = new ComboBox();
            dropDownCategoryIncome = new ComboBox();
            btnAddIncome = new Button();
            txtValueAddIncome = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            panel3 = new Panel();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            pictureBox3 = new PictureBox();
            label22 = new Label();
            tabAccounts = new TabPage();
            groupBox1 = new GroupBox();
            btnCancelAddAccount = new Button();
            btnAddAccount = new Button();
            dropDownCurrencyAddAccount = new ComboBox();
            txtBoxAmountAddAccount = new TextBox();
            txtBoxNameAddAccount = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            listViewAccounts = new ListView();
            accountName = new ColumnHeader();
            balance = new ColumnHeader();
            panel1 = new Panel();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            pictureBox2 = new PictureBox();
            label17 = new Label();
            tabBudgets = new TabPage();
            tblBudgetProgress = new TableLayoutPanel();
            listViewBudgets = new ListView();
            groupBox5 = new GroupBox();
            btnCancelBudget = new Button();
            btnCreateABudget = new Button();
            dropDownAccountBudget = new ComboBox();
            txtBudgetAmount = new TextBox();
            dropDownCategoryBudget = new ComboBox();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            groupBox2 = new GroupBox();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            progressBar1 = new ProgressBar();
            panel4 = new Panel();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            tabReport = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label39 = new Label();
            label43 = new Label();
            label44 = new Label();
            bTestNotification = new Button();
            DASHBOARD.SuspendLayout();
            tabDashboard.SuspendLayout();
            groupBox6.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabTransactions.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabAccounts.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabBudgets.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.Controls.Add(tabDashboard);
            DASHBOARD.Controls.Add(tabTransactions);
            DASHBOARD.Controls.Add(tabAccounts);
            DASHBOARD.Controls.Add(tabBudgets);
            DASHBOARD.Controls.Add(tabReport);
            DASHBOARD.Location = new Point(12, 12);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.SelectedIndex = 0;
            DASHBOARD.Size = new Size(1213, 727);
            DASHBOARD.TabIndex = 5;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(bTestNotification);
            tabDashboard.Controls.Add(tblAccountsSummary2);
            tabDashboard.Controls.Add(tblAccountsSummary);
            tabDashboard.Controls.Add(groupBox6);
            tabDashboard.Controls.Add(panel2);
            tabDashboard.Location = new Point(4, 29);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1205, 694);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "DASHBOARD";
            tabDashboard.UseVisualStyleBackColor = true;
            tabDashboard.Click += tabDashboard_Click;
            // 
            // tblAccountsSummary2
            // 
            tblAccountsSummary2.AutoSize = true;
            tblAccountsSummary2.ColumnCount = 2;
            tblAccountsSummary2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAccountsSummary2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAccountsSummary2.Location = new Point(354, 370);
            tblAccountsSummary2.Name = "tblAccountsSummary2";
            tblAccountsSummary2.RowCount = 1;
            tblAccountsSummary2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblAccountsSummary2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblAccountsSummary2.Size = new Size(673, 318);
            tblAccountsSummary2.TabIndex = 6;
            // 
            // tblAccountsSummary
            // 
            tblAccountsSummary.AutoScroll = true;
            tblAccountsSummary.AutoSize = true;
            tblAccountsSummary.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblAccountsSummary.ColumnCount = 2;
            tblAccountsSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAccountsSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAccountsSummary.Location = new Point(446, 451);
            tblAccountsSummary.Name = "tblAccountsSummary";
            tblAccountsSummary.RowCount = 1;
            tblAccountsSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblAccountsSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblAccountsSummary.Size = new Size(0, 0);
            tblAccountsSummary.TabIndex = 5;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ControlDarkDark;
            groupBox6.Controls.Add(label38);
            groupBox6.Controls.Add(txtBalance);
            groupBox6.Controls.Add(label40);
            groupBox6.Controls.Add(txtTotalBalance);
            groupBox6.Controls.Add(label41);
            groupBox6.Controls.Add(BalanceLabel);
            groupBox6.Controls.Add(label42);
            groupBox6.Font = new Font("Segoe UI", 14F);
            groupBox6.ForeColor = Color.Coral;
            groupBox6.Location = new Point(354, 59);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(609, 275);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "SUMMARY";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label38.ForeColor = Color.Black;
            label38.Location = new Point(33, 167);
            label38.Name = "label38";
            label38.Size = new Size(474, 32);
            label38.TabIndex = 0;
            label38.Text = "----------------------------------------------";
            // 
            // txtBalance
            // 
            txtBalance.AutoSize = true;
            txtBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtBalance.ForeColor = Color.Black;
            txtBalance.Location = new Point(320, 90);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(256, 32);
            txtBalance.TabIndex = 0;
            txtBalance.Text = "<BALANCE WALETS>";
            txtBalance.Click += txtBalance_Click;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label40.ForeColor = Color.Black;
            label40.Location = new Point(320, 135);
            label40.Name = "label40";
            label40.Size = new Size(248, 32);
            label40.TabIndex = 0;
            label40.Text = "<BALANCE CREDIT>";
            // 
            // txtTotalBalance
            // 
            txtTotalBalance.AutoSize = true;
            txtTotalBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtTotalBalance.ForeColor = Color.Black;
            txtTotalBalance.Location = new Point(350, 209);
            txtTotalBalance.Name = "txtTotalBalance";
            txtTotalBalance.Size = new Size(157, 32);
            txtTotalBalance.TabIndex = 0;
            txtTotalBalance.Text = "<BALANCE>";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label41.ForeColor = Color.Black;
            label41.Location = new Point(26, 135);
            label41.Name = "label41";
            label41.Size = new Size(154, 32);
            label41.TabIndex = 0;
            label41.Text = "Credit Cards";
            label41.Click += label41_Click;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BalanceLabel.ForeColor = Color.Black;
            BalanceLabel.Location = new Point(26, 90);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(102, 32);
            BalanceLabel.TabIndex = 0;
            BalanceLabel.Text = "Balance";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label42.ForeColor = Color.Black;
            label42.Location = new Point(26, 45);
            label42.Name = "label42";
            label42.Size = new Size(123, 32);
            label42.TabIndex = 0;
            label42.Text = "Summary";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(navDashboard);
            panel2.Location = new Point(31, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 551);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(78, 281);
            label4.Name = "label4";
            label4.Size = new Size(99, 34);
            label4.TabIndex = 5;
            label4.Text = "REPORT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(69, 140);
            label3.Name = "label3";
            label3.Size = new Size(137, 34);
            label3.TabIndex = 4;
            label3.Text = "ACCOUNTS";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(69, 210);
            label2.Name = "label2";
            label2.Size = new Size(117, 34);
            label2.TabIndex = 3;
            label2.Text = "BUDGETS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(69, 76);
            label1.Name = "label1";
            label1.Size = new Size(187, 34);
            label1.TabIndex = 2;
            label1.Text = "TRANSACTIONS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.dashboard_icon1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(31, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // navDashboard
            // 
            navDashboard.AutoSize = true;
            navDashboard.BorderStyle = BorderStyle.FixedSingle;
            navDashboard.Font = new Font("Segoe UI", 14F);
            navDashboard.ForeColor = Color.WhiteSmoke;
            navDashboard.Location = new Point(69, 13);
            navDashboard.Name = "navDashboard";
            navDashboard.Size = new Size(154, 34);
            navDashboard.TabIndex = 0;
            navDashboard.Text = "DASHBOARD";
            // 
            // tabTransactions
            // 
            tabTransactions.Controls.Add(groupBox4);
            tabTransactions.Controls.Add(groupBox3);
            tabTransactions.Controls.Add(panel3);
            tabTransactions.Location = new Point(4, 29);
            tabTransactions.Name = "tabTransactions";
            tabTransactions.Padding = new Padding(3);
            tabTransactions.Size = new Size(1205, 694);
            tabTransactions.TabIndex = 1;
            tabTransactions.Text = "TRANSACTIONS";
            tabTransactions.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(btnCancelAddExpense);
            groupBox4.Controls.Add(dropDownCategoryExpense);
            groupBox4.Controls.Add(dropDownAccountAddExpense);
            groupBox4.Controls.Add(btnAddExpense);
            groupBox4.Controls.Add(txtValueAddExpense);
            groupBox4.Controls.Add(label27);
            groupBox4.Controls.Add(label28);
            groupBox4.Controls.Add(label29);
            groupBox4.Controls.Add(label30);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(307, 379);
            groupBox4.Name = "groupBox4";
            groupBox4.RightToLeft = RightToLeft.No;
            groupBox4.Size = new Size(449, 319);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "ADD EXPENSE";
            // 
            // btnCancelAddExpense
            // 
            btnCancelAddExpense.Location = new Point(204, 269);
            btnCancelAddExpense.Name = "btnCancelAddExpense";
            btnCancelAddExpense.Size = new Size(99, 40);
            btnCancelAddExpense.TabIndex = 13;
            btnCancelAddExpense.Text = "Cancel";
            btnCancelAddExpense.UseVisualStyleBackColor = true;
            // 
            // dropDownCategoryExpense
            // 
            dropDownCategoryExpense.FormattingEnabled = true;
            dropDownCategoryExpense.Location = new Point(168, 55);
            dropDownCategoryExpense.Name = "dropDownCategoryExpense";
            dropDownCategoryExpense.Size = new Size(151, 36);
            dropDownCategoryExpense.TabIndex = 13;
            dropDownCategoryExpense.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // dropDownAccountAddExpense
            // 
            dropDownAccountAddExpense.FormattingEnabled = true;
            dropDownAccountAddExpense.Location = new Point(168, 137);
            dropDownAccountAddExpense.Name = "dropDownAccountAddExpense";
            dropDownAccountAddExpense.Size = new Size(151, 36);
            dropDownAccountAddExpense.TabIndex = 12;
            dropDownAccountAddExpense.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.FromArgb(229, 57, 53);
            btnAddExpense.Location = new Point(331, 266);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(94, 43);
            btnAddExpense.TabIndex = 9;
            btnAddExpense.Text = "Add";
            btnAddExpense.UseVisualStyleBackColor = false;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtValueAddExpense
            // 
            txtValueAddExpense.Location = new Point(168, 213);
            txtValueAddExpense.Name = "txtValueAddExpense";
            txtValueAddExpense.Size = new Size(125, 34);
            txtValueAddExpense.TabIndex = 8;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(17, 216);
            label27.Name = "label27";
            label27.Size = new Size(59, 28);
            label27.TabIndex = 3;
            label27.Text = "Value";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(17, 140);
            label28.Name = "label28";
            label28.Size = new Size(84, 28);
            label28.TabIndex = 2;
            label28.Text = "Account";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(11, 132);
            label29.Name = "label29";
            label29.Size = new Size(0, 28);
            label29.TabIndex = 1;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(17, 63);
            label30.Name = "label30";
            label30.Size = new Size(97, 28);
            label30.TabIndex = 0;
            label30.Text = "Category ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(btnCancelAddIncome);
            groupBox3.Controls.Add(dropDownAccountAddIncome);
            groupBox3.Controls.Add(dropDownCategoryIncome);
            groupBox3.Controls.Add(btnAddIncome);
            groupBox3.Controls.Add(txtValueAddIncome);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label26);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(307, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(449, 315);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "ADD INCOME";
            // 
            // btnCancelAddIncome
            // 
            btnCancelAddIncome.Location = new Point(204, 262);
            btnCancelAddIncome.Name = "btnCancelAddIncome";
            btnCancelAddIncome.Size = new Size(99, 42);
            btnCancelAddIncome.TabIndex = 12;
            btnCancelAddIncome.Text = "Cancel";
            btnCancelAddIncome.UseVisualStyleBackColor = true;
            // 
            // dropDownAccountAddIncome
            // 
            dropDownAccountAddIncome.FormattingEnabled = true;
            dropDownAccountAddIncome.Location = new Point(168, 138);
            dropDownAccountAddIncome.Name = "dropDownAccountAddIncome";
            dropDownAccountAddIncome.Size = new Size(151, 36);
            dropDownAccountAddIncome.TabIndex = 11;
            // 
            // dropDownCategoryIncome
            // 
            dropDownCategoryIncome.FormattingEnabled = true;
            dropDownCategoryIncome.Location = new Point(168, 63);
            dropDownCategoryIncome.Name = "dropDownCategoryIncome";
            dropDownCategoryIncome.Size = new Size(151, 36);
            dropDownCategoryIncome.TabIndex = 10;
            dropDownCategoryIncome.SelectedIndexChanged += dropDownCategoryIncome_SelectedIndexChanged;
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.FromArgb(67, 160, 71);
            btnAddIncome.Location = new Point(331, 262);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(94, 42);
            btnAddIncome.TabIndex = 9;
            btnAddIncome.Text = "Add";
            btnAddIncome.UseVisualStyleBackColor = false;
            btnAddIncome.Click += btnAddIncome_Click_1;
            // 
            // txtValueAddIncome
            // 
            txtValueAddIncome.Location = new Point(168, 213);
            txtValueAddIncome.Name = "txtValueAddIncome";
            txtValueAddIncome.Size = new Size(125, 34);
            txtValueAddIncome.TabIndex = 8;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(17, 216);
            label23.Name = "label23";
            label23.Size = new Size(59, 28);
            label23.TabIndex = 3;
            label23.Text = "Value";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(17, 140);
            label24.Name = "label24";
            label24.Size = new Size(84, 28);
            label24.TabIndex = 2;
            label24.Text = "Account";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(11, 132);
            label25.Name = "label25";
            label25.Size = new Size(0, 28);
            label25.TabIndex = 1;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(17, 63);
            label26.Name = "label26";
            label26.Size = new Size(97, 28);
            label26.TabIndex = 0;
            label26.Text = "Category ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label22);
            panel3.Location = new Point(16, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 551);
            panel3.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Segoe UI", 14F);
            label18.ForeColor = Color.WhiteSmoke;
            label18.Location = new Point(78, 281);
            label18.Name = "label18";
            label18.Size = new Size(99, 34);
            label18.TabIndex = 5;
            label18.Text = "REPORT";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Segoe UI", 14F);
            label19.ForeColor = Color.WhiteSmoke;
            label19.Location = new Point(69, 140);
            label19.Name = "label19";
            label19.Size = new Size(137, 34);
            label19.TabIndex = 4;
            label19.Text = "ACCOUNTS";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.Font = new Font("Segoe UI", 14F);
            label20.ForeColor = Color.WhiteSmoke;
            label20.Location = new Point(69, 210);
            label20.Name = "label20";
            label20.Size = new Size(117, 34);
            label20.TabIndex = 3;
            label20.Text = "BUDGETS";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("Segoe UI", 14F);
            label21.ForeColor = Color.WhiteSmoke;
            label21.Location = new Point(69, 76);
            label21.Name = "label21";
            label21.Size = new Size(187, 34);
            label21.TabIndex = 2;
            label21.Text = "TRANSACTIONS";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.dashboard_icon1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(31, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Segoe UI", 14F);
            label22.ForeColor = Color.WhiteSmoke;
            label22.Location = new Point(69, 13);
            label22.Name = "label22";
            label22.Size = new Size(154, 34);
            label22.TabIndex = 0;
            label22.Text = "DASHBOARD";
            // 
            // tabAccounts
            // 
            tabAccounts.Controls.Add(groupBox1);
            tabAccounts.Controls.Add(listViewAccounts);
            tabAccounts.Controls.Add(panel1);
            tabAccounts.Location = new Point(4, 29);
            tabAccounts.Name = "tabAccounts";
            tabAccounts.Padding = new Padding(3);
            tabAccounts.Size = new Size(1205, 694);
            tabAccounts.TabIndex = 2;
            tabAccounts.Text = "ACCOUNTS";
            tabAccounts.UseVisualStyleBackColor = true;
            tabAccounts.Click += tabAccounts_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelAddAccount);
            groupBox1.Controls.Add(btnAddAccount);
            groupBox1.Controls.Add(dropDownCurrencyAddAccount);
            groupBox1.Controls.Add(txtBoxAmountAddAccount);
            groupBox1.Controls.Add(txtBoxNameAddAccount);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(358, 345);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 302);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Account";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // btnCancelAddAccount
            // 
            btnCancelAddAccount.Location = new Point(209, 233);
            btnCancelAddAccount.Name = "btnCancelAddAccount";
            btnCancelAddAccount.Size = new Size(101, 43);
            btnCancelAddAccount.TabIndex = 9;
            btnCancelAddAccount.Text = "Cancel";
            btnCancelAddAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(340, 233);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(101, 43);
            btnAddAccount.TabIndex = 8;
            btnAddAccount.Text = "Add";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // dropDownCurrencyAddAccount
            // 
            dropDownCurrencyAddAccount.FormattingEnabled = true;
            dropDownCurrencyAddAccount.Location = new Point(209, 101);
            dropDownCurrencyAddAccount.Name = "dropDownCurrencyAddAccount";
            dropDownCurrencyAddAccount.Size = new Size(158, 36);
            dropDownCurrencyAddAccount.TabIndex = 7;
            // 
            // txtBoxAmountAddAccount
            // 
            txtBoxAmountAddAccount.Location = new Point(209, 167);
            txtBoxAmountAddAccount.Name = "txtBoxAmountAddAccount";
            txtBoxAmountAddAccount.Size = new Size(158, 34);
            txtBoxAmountAddAccount.TabIndex = 6;
            // 
            // txtBoxNameAddAccount
            // 
            txtBoxNameAddAccount.Location = new Point(209, 39);
            txtBoxNameAddAccount.Name = "txtBoxNameAddAccount";
            txtBoxNameAddAccount.Size = new Size(158, 34);
            txtBoxNameAddAccount.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 109);
            label8.Name = "label8";
            label8.Size = new Size(166, 28);
            label8.TabIndex = 3;
            label8.Text = "Account Currency";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 170);
            label7.Name = "label7";
            label7.Size = new Size(136, 28);
            label7.TabIndex = 2;
            label7.Text = "Initial Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 45);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 0;
            label5.Text = "Name";
            // 
            // listViewAccounts
            // 
            listViewAccounts.Columns.AddRange(new ColumnHeader[] { accountName, balance });
            listViewAccounts.FullRowSelect = true;
            listViewAccounts.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listViewAccounts.Location = new Point(358, 54);
            listViewAccounts.Name = "listViewAccounts";
            listViewAccounts.Size = new Size(411, 258);
            listViewAccounts.TabIndex = 5;
            listViewAccounts.UseCompatibleStateImageBehavior = false;
            listViewAccounts.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // accountName
            // 
            accountName.Text = "Account Name";
            // 
            // balance
            // 
            balance.Text = "Balance";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(19, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 551);
            panel1.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI", 14F);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(78, 281);
            label13.Name = "label13";
            label13.Size = new Size(99, 34);
            label13.TabIndex = 5;
            label13.Text = "REPORT";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI", 14F);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(69, 140);
            label14.Name = "label14";
            label14.Size = new Size(137, 34);
            label14.TabIndex = 4;
            label14.Text = "ACCOUNTS";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI", 14F);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(69, 210);
            label15.Name = "label15";
            label15.Size = new Size(117, 34);
            label15.TabIndex = 3;
            label15.Text = "BUDGETS";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Segoe UI", 14F);
            label16.ForeColor = Color.WhiteSmoke;
            label16.Location = new Point(69, 76);
            label16.Name = "label16";
            label16.Size = new Size(187, 34);
            label16.TabIndex = 2;
            label16.Text = "TRANSACTIONS";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.dashboard_icon1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(31, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Segoe UI", 14F);
            label17.ForeColor = Color.WhiteSmoke;
            label17.Location = new Point(69, 13);
            label17.Name = "label17";
            label17.Size = new Size(154, 34);
            label17.TabIndex = 0;
            label17.Text = "DASHBOARD";
            // 
            // tabBudgets
            // 
            tabBudgets.Controls.Add(tblBudgetProgress);
            tabBudgets.Controls.Add(listViewBudgets);
            tabBudgets.Controls.Add(groupBox5);
            tabBudgets.Controls.Add(groupBox2);
            tabBudgets.Controls.Add(panel4);
            tabBudgets.Location = new Point(4, 29);
            tabBudgets.Name = "tabBudgets";
            tabBudgets.Padding = new Padding(3);
            tabBudgets.Size = new Size(1205, 694);
            tabBudgets.TabIndex = 3;
            tabBudgets.Text = "BUDGETS";
            tabBudgets.UseVisualStyleBackColor = true;
            // 
            // tblBudgetProgress
            // 
            tblBudgetProgress.AutoSize = true;
            tblBudgetProgress.ColumnCount = 2;
            tblBudgetProgress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblBudgetProgress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblBudgetProgress.Location = new Point(837, 304);
            tblBudgetProgress.Name = "tblBudgetProgress";
            tblBudgetProgress.RowCount = 1;
            tblBudgetProgress.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblBudgetProgress.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblBudgetProgress.Size = new Size(326, 202);
            tblBudgetProgress.TabIndex = 9;
            // 
            // listViewBudgets
            // 
            listViewBudgets.Location = new Point(837, 61);
            listViewBudgets.Name = "listViewBudgets";
            listViewBudgets.Size = new Size(277, 219);
            listViewBudgets.TabIndex = 8;
            listViewBudgets.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnCancelBudget);
            groupBox5.Controls.Add(btnCreateABudget);
            groupBox5.Controls.Add(dropDownAccountBudget);
            groupBox5.Controls.Add(txtBudgetAmount);
            groupBox5.Controls.Add(dropDownCategoryBudget);
            groupBox5.Controls.Add(label33);
            groupBox5.Controls.Add(label32);
            groupBox5.Controls.Add(label31);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(372, 356);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(456, 318);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "CREATE NEW BUDGET";
            // 
            // btnCancelBudget
            // 
            btnCancelBudget.Location = new Point(198, 259);
            btnCancelBudget.Name = "btnCancelBudget";
            btnCancelBudget.Size = new Size(104, 40);
            btnCancelBudget.TabIndex = 8;
            btnCancelBudget.Text = "Cancel";
            btnCancelBudget.UseVisualStyleBackColor = true;
            // 
            // btnCreateABudget
            // 
            btnCreateABudget.Location = new Point(344, 259);
            btnCreateABudget.Name = "btnCreateABudget";
            btnCreateABudget.Size = new Size(90, 40);
            btnCreateABudget.TabIndex = 6;
            btnCreateABudget.Text = "Create";
            btnCreateABudget.UseVisualStyleBackColor = true;
            btnCreateABudget.Click += btnCreateABudget_Click;
            // 
            // dropDownAccountBudget
            // 
            dropDownAccountBudget.FormattingEnabled = true;
            dropDownAccountBudget.Location = new Point(198, 181);
            dropDownAccountBudget.Name = "dropDownAccountBudget";
            dropDownAccountBudget.Size = new Size(151, 36);
            dropDownAccountBudget.TabIndex = 5;
            dropDownAccountBudget.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // txtBudgetAmount
            // 
            txtBudgetAmount.Location = new Point(198, 44);
            txtBudgetAmount.Name = "txtBudgetAmount";
            txtBudgetAmount.Size = new Size(125, 34);
            txtBudgetAmount.TabIndex = 4;
            // 
            // dropDownCategoryBudget
            // 
            dropDownCategoryBudget.FormattingEnabled = true;
            dropDownCategoryBudget.Location = new Point(198, 114);
            dropDownCategoryBudget.Name = "dropDownCategoryBudget";
            dropDownCategoryBudget.Size = new Size(151, 36);
            dropDownCategoryBudget.TabIndex = 3;
            dropDownCategoryBudget.SelectedIndexChanged += dropDownCategoryBudget_SelectedIndexChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(21, 114);
            label33.Name = "label33";
            label33.Size = new Size(92, 28);
            label33.TabIndex = 2;
            label33.Text = "Category";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(21, 181);
            label32.Name = "label32";
            label32.Size = new Size(84, 28);
            label32.TabIndex = 1;
            label32.Text = "Account";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(21, 47);
            label31.Name = "label31";
            label31.Size = new Size(151, 28);
            label31.TabIndex = 0;
            label31.Text = "Budget Amount";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label44);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(label43);
            groupBox2.Controls.Add(label39);
            groupBox2.Controls.Add(label37);
            groupBox2.Controls.Add(label36);
            groupBox2.Controls.Add(label35);
            groupBox2.Controls.Add(label34);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(372, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 247);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "MONTHLY BUDGETS";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(18, 161);
            label37.Name = "label37";
            label37.Size = new Size(0, 28);
            label37.TabIndex = 4;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(24, 161);
            label36.Name = "label36";
            label36.Size = new Size(187, 28);
            label36.TabIndex = 3;
            label36.Text = "<AMOUNT SPENT>";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(340, 161);
            label35.Name = "label35";
            label35.Size = new Size(94, 28);
            label35.TabIndex = 2;
            label35.Text = "<TOTAL>";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(19, 63);
            label34.Name = "label34";
            label34.Size = new Size(136, 28);
            label34.TabIndex = 1;
            label34.Text = "<CATEGORY>";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(41, 114);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(364, 14);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 70;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(26, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 551);
            panel4.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(78, 281);
            label6.Name = "label6";
            label6.Size = new Size(99, 34);
            label6.TabIndex = 5;
            label6.Text = "REPORT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(69, 140);
            label9.Name = "label9";
            label9.Size = new Size(137, 34);
            label9.TabIndex = 4;
            label9.Text = "ACCOUNTS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 14F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(69, 210);
            label10.Name = "label10";
            label10.Size = new Size(117, 34);
            label10.TabIndex = 3;
            label10.Text = "BUDGETS";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 14F);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(69, 76);
            label11.Name = "label11";
            label11.Size = new Size(187, 34);
            label11.TabIndex = 2;
            label11.Text = "TRANSACTIONS";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.dashboard_icon1;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(31, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 14F);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(69, 13);
            label12.Name = "label12";
            label12.Size = new Size(154, 34);
            label12.TabIndex = 0;
            label12.Text = "DASHBOARD";
            // 
            // tabReport
            // 
            tabReport.Location = new Point(4, 29);
            tabReport.Name = "tabReport";
            tabReport.Padding = new Padding(3);
            tabReport.Size = new Size(1205, 694);
            tabReport.TabIndex = 4;
            tabReport.Text = "REPORT";
            tabReport.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(288, 92);
            label39.Name = "label39";
            label39.Size = new Size(17, 28);
            label39.TabIndex = 5;
            label39.Text = "|";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(288, 112);
            label43.Name = "label43";
            label43.Size = new Size(17, 28);
            label43.TabIndex = 5;
            label43.Text = "|";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(288, 69);
            label44.Name = "label44";
            label44.Size = new Size(50, 28);
            label44.TabIndex = 6;
            label44.Text = "70%";
            // 
            // bTestNotification
            // 
            bTestNotification.Location = new Point(1035, 224);
            bTestNotification.Name = "bTestNotification";
            bTestNotification.Size = new Size(94, 29);
            bTestNotification.TabIndex = 7;
            bTestNotification.Text = "Notify";
            bTestNotification.UseVisualStyleBackColor = true;
            bTestNotification.Click += bTestNotification_Click;
            // 
            // Sanbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 768);
            Controls.Add(DASHBOARD);
            Name = "Sanbox";
            Text = "Sanbox";
            DASHBOARD.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabTransactions.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabAccounts.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabBudgets.ResumeLayout(false);
            tabBudgets.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl DASHBOARD;
        private TabPage tabDashboard;
        private TabPage tabTransactions;
        private TabPage tabAccounts;
        private TabPage tabBudgets;
        private TabPage tabReport;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label navDashboard;
        private Panel panel1;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox2;
        private Label label17;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private GroupBox groupBox4;
        private ComboBox dropDownCategoryExpense;
        private ComboBox dropDownAccountAddExpense;
        private Button btnAddExpense;
        private TextBox txtValueAddExpense;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private GroupBox groupBox3;
        private ComboBox dropDownAccountAddIncome;
        private ComboBox dropDownCategoryIncome;
        private Button btnAddIncome;
        private TextBox txtValueAddIncome;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Panel panel3;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private PictureBox pictureBox3;
        private Label label22;
        private ListView listViewAccounts;
        private ColumnHeader accountName;
        private ColumnHeader balance;
        private GroupBox groupBox1;
        private TextBox txtBoxNameAddAccount;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtBoxAmountAddAccount;
        private ComboBox dropDownCurrencyAddAccount;
        private Button btnAddAccount;
        private Panel panel4;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox4;
        private Label label12;
        private Button btnCancelAddAccount;
        private Button btnCancelAddExpense;
        private Button btnCancelAddIncome;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private ProgressBar progressBar1;
        private ComboBox dropDownCategoryBudget;
        private Label label33;
        private Label label32;
        private Label label31;
        private ComboBox dropDownAccountBudget;
        private TextBox txtBudgetAmount;
        private Button btnCancelBudget;
        private Button btnCreateABudget;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label37;
        private GroupBox groupBox6;
        private Label label38;
        private Label txtBalance;
        private Label label40;
        private Label txtTotalBalance;
        private Label BalanceLabel;
        private Label label42;
        private Label label41;
        private TableLayoutPanel tblAccountsSummary;
        private TableLayoutPanel tblAccountsSummary2;
        private ListView listViewBudgets;
        private TableLayoutPanel tblBudgetProgress;
        private Label label44;
        private Label label43;
        private Label label39;
        private Button bTestNotification;
    }
}