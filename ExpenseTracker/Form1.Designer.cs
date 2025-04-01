namespace ExpenseTracker {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            navDashboard = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            TotalBalanceText = new Label();
            label6 = new Label();
            BalanceLabel = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.ForeColor = Color.Coral;
            groupBox1.Location = new Point(1114, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "TRANSACTIONS";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item1", "Item2", "Item3", "Item4" });
            comboBox1.Location = new Point(320, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 39);
            comboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 54);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 0;
            label2.Text = "DASHBOARD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(161, 10);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 0;
            label1.Text = "TRANSACTIONS";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(navDashboard);
            panel2.Location = new Point(12, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 548);
            panel2.TabIndex = 1;
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TotalBalanceText);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(BalanceLabel);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.ForeColor = Color.Coral;
            groupBox2.Location = new Point(344, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(609, 275);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "SUMMARY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 167);
            label4.Name = "label4";
            label4.Size = new Size(474, 32);
            label4.TabIndex = 0;
            label4.Text = "----------------------------------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(320, 90);
            label7.Name = "label7";
            label7.Size = new Size(256, 32);
            label7.TabIndex = 0;
            label7.Text = "<BALANCE WALETS>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(320, 135);
            label5.Name = "label5";
            label5.Size = new Size(248, 32);
            label5.TabIndex = 0;
            label5.Text = "<BALANCE CREDIT>";
            // 
            // TotalBalanceText
            // 
            TotalBalanceText.AutoSize = true;
            TotalBalanceText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TotalBalanceText.ForeColor = Color.Black;
            TotalBalanceText.Location = new Point(350, 209);
            TotalBalanceText.Name = "TotalBalanceText";
            TotalBalanceText.Size = new Size(157, 32);
            TotalBalanceText.TabIndex = 0;
            TotalBalanceText.Text = "<BALANCE>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(26, 135);
            label6.Name = "label6";
            label6.Size = new Size(154, 32);
            label6.TabIndex = 0;
            label6.Text = "Credit Cards";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 45);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 0;
            label3.Text = "Summary";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlDarkDark;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("Segoe UI", 14F);
            groupBox3.ForeColor = Color.Coral;
            groupBox3.Location = new Point(344, 383);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(609, 275);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "THIS MONTH";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 167);
            label8.Name = "label8";
            label8.Size = new Size(474, 32);
            label8.TabIndex = 0;
            label8.Text = "----------------------------------------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(320, 90);
            label9.Name = "label9";
            label9.Size = new Size(256, 32);
            label9.TabIndex = 0;
            label9.Text = "<BALANCE WALETS>";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(320, 135);
            label10.Name = "label10";
            label10.Size = new Size(248, 32);
            label10.TabIndex = 0;
            label10.Text = "<BALANCE CREDIT>";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(350, 209);
            label11.Name = "label11";
            label11.Size = new Size(157, 32);
            label11.TabIndex = 0;
            label11.Text = "<BALANCE>";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(26, 135);
            label12.Name = "label12";
            label12.Size = new Size(154, 32);
            label12.TabIndex = 0;
            label12.Text = "Credit Cards";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(26, 90);
            label13.Name = "label13";
            label13.Size = new Size(102, 32);
            label13.TabIndex = 0;
            label13.Text = "Balance";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(26, 45);
            label14.Name = "label14";
            label14.Size = new Size(123, 32);
            label14.TabIndex = 0;
            label14.Text = "Summary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1837, 999);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label navDashboard;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label6;
        private Label BalanceLabel;
        private Label label3;
        private Label TotalBalanceText;
        private Label label7;
        private Label label5;
        private GroupBox groupBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
