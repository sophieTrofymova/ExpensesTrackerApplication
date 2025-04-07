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
            monthDropDown = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            listView1 = new ListView();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            GroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(groupBox3);
            GroupBox.Controls.Add(groupBox4);
            GroupBox.Controls.Add(groupBox2);
            GroupBox.Controls.Add(groupBox1);
            GroupBox.Size = new Size(1293, 721);
            GroupBox.Text = "Transactions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 3;
            label1.Text = "Month:";
            // 
            // monthDropDown
            // 
            monthDropDown.BackColor = SystemColors.WindowFrame;
            monthDropDown.FormattingEnabled = true;
            monthDropDown.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthDropDown.Location = new Point(40, 70);
            monthDropDown.Name = "monthDropDown";
            monthDropDown.Size = new Size(197, 39);
            monthDropDown.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(monthDropDown);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(35, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1229, 203);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(35, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 221);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "AddExpense";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.BackColor = SystemColors.WindowFrame;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox1.Location = new Point(40, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 39);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 35);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 3;
            label2.Text = "Month:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(35, 494);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(347, 221);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "AddIncome";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.BackColor = SystemColors.WindowFrame;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox2.Location = new Point(40, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(285, 39);
            comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 35);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 3;
            label3.Text = "Month:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(listView1);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(399, 266);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(865, 449);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Transactions";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.WindowFrame;
            listView1.Location = new Point(18, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(842, 393);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 35);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.WindowFrame;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox3.Location = new Point(296, 70);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(197, 39);
            comboBox3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(592, 35);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 3;
            label5.Text = "Account:";
            // 
            // comboBox4
            // 
            comboBox4.BackColor = SystemColors.WindowFrame;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBox4.Location = new Point(610, 70);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(197, 39);
            comboBox4.TabIndex = 2;
            // 
            // TransactionsElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Location = new Point(0, 0);
            Name = "TransactionsElement";
            Size = new Size(1306, 771);
            Title = "Transactions";
            GroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        public ComboBox monthDropDown;
        private Label label1;
        private GroupBox groupBox3;
        public ComboBox comboBox2;
        private Label label3;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        public ComboBox comboBox1;
        private Label label2;
        private ListView listView1;
        public ComboBox comboBox3;
        private Label label4;
        public ComboBox comboBox4;
        private Label label5;
    }
}
