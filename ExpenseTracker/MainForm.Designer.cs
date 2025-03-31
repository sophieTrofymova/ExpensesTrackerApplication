namespace ExpenseTracker {
    partial class MainForm {
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
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            MainContainer = new Panel();
            draggablePanel = new Panel();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            TotalBalanceText = new Label();
            label6 = new Label();
            BalanceLabel = new Label();
            label3 = new Label();
            navBar1 = new NavBar();
            navDashboard = new NavBarButton();
            navTransactions = new NavBarButton();
            navReccurent = new NavBarButton();
            navAccounts = new NavBarButton();
            navBarButton5 = new NavBarButton();
            navBarButton6 = new NavBarButton();
            navBarButton7 = new NavBarButton();
            groupBox1.SuspendLayout();
            MainContainer.SuspendLayout();
            draggablePanel.SuspendLayout();
            groupBox2.SuspendLayout();
            navBar1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(41, 41, 41);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.ForeColor = Color.Coral;
            groupBox1.Location = new Point(83, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 161);
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
            // MainContainer
            // 
            MainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainContainer.AutoScroll = true;
            MainContainer.BackColor = Color.SlateGray;
            MainContainer.Controls.Add(draggablePanel);
            MainContainer.Controls.Add(groupBox1);
            MainContainer.Location = new Point(397, 10);
            MainContainer.Name = "MainContainer";
            MainContainer.Size = new Size(857, 635);
            MainContainer.TabIndex = 5;
            // 
            // draggablePanel
            // 
            draggablePanel.BackColor = Color.CornflowerBlue;
            draggablePanel.Controls.Add(groupBox2);
            draggablePanel.Location = new Point(92, 56);
            draggablePanel.Margin = new Padding(10);
            draggablePanel.MinimumSize = new Size(350, 220);
            draggablePanel.Name = "draggablePanel";
            draggablePanel.Padding = new Padding(5, 35, 5, 5);
            draggablePanel.Size = new Size(507, 305);
            draggablePanel.TabIndex = 4;
            draggablePanel.Visible = false;
            draggablePanel.Paint += panel2_Paint;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(41, 41, 41);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TotalBalanceText);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(BalanceLabel);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.ForeColor = Color.Coral;
            groupBox2.Location = new Point(5, 35);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 265);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "SUMMARY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(31, 167);
            label4.Name = "label4";
            label4.Size = new Size(474, 32);
            label4.TabIndex = 0;
            label4.Text = "----------------------------------------------";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(232, 90);
            label7.Name = "label7";
            label7.Size = new Size(256, 32);
            label7.TabIndex = 0;
            label7.Text = "<BALANCE WALETS>";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(232, 135);
            label5.Name = "label5";
            label5.Size = new Size(248, 32);
            label5.TabIndex = 0;
            label5.Text = "<BALANCE CREDIT>";
            // 
            // TotalBalanceText
            // 
            TotalBalanceText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalBalanceText.AutoSize = true;
            TotalBalanceText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TotalBalanceText.ForeColor = Color.WhiteSmoke;
            TotalBalanceText.Location = new Point(262, 209);
            TotalBalanceText.Name = "TotalBalanceText";
            TotalBalanceText.Size = new Size(157, 32);
            TotalBalanceText.TabIndex = 0;
            TotalBalanceText.Text = "<BALANCE>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
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
            BalanceLabel.ForeColor = Color.WhiteSmoke;
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
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(26, 45);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 0;
            label3.Text = "Summary";
            // 
            // navBar1
            // 
            navBar1.AutoScroll = true;
            navBar1.BackColor = Color.WhiteSmoke;
            navBar1.Buttons.Add(navDashboard);
            navBar1.Buttons.Add(navTransactions);
            navBar1.Buttons.Add(navReccurent);
            navBar1.Buttons.Add(navAccounts);
            navBar1.Buttons.Add(navBarButton5);
            navBar1.Buttons.Add(navBarButton6);
            navBar1.Buttons.Add(navBarButton7);
            navBar1.Controls.Add(navDashboard);
            navBar1.Controls.Add(navTransactions);
            navBar1.Controls.Add(navReccurent);
            navBar1.Controls.Add(navAccounts);
            navBar1.Controls.Add(navBarButton5);
            navBar1.Controls.Add(navBarButton6);
            navBar1.Controls.Add(navBarButton7);
            navBar1.FlowDirection = FlowDirection.TopDown;
            navBar1.Location = new Point(12, 12);
            navBar1.MinimumSize = new Size(50, 50);
            navBar1.Name = "navBar1";
            navBar1.Size = new Size(379, 494);
            navBar1.TabIndex = 6;
            navBar1.WrapContents = false;
            // 
            // navDashboard
            // 
            navDashboard.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navDashboard.AutoSize = true;
            navDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navDashboard.BackColor = Color.White;
            navDashboard.DisplayIcon = "e002";
            navDashboard.DisplayLabel = "Dashboard";
            navDashboard.DownColor = Color.FromArgb(150, 150, 150);
            navDashboard.HoverColor = Color.FromArgb(238, 238, 238);
            navDashboard.IsActive = false;
            navDashboard.Location = new Point(0, 0);
            navDashboard.Margin = new Padding(0);
            navDashboard.MinIconWidth = 64;
            navDashboard.Name = "navDashboard";
            navDashboard.NormalColor = Color.White;
            navDashboard.NormalForeColor = Color.Black;
            navDashboard.Size = new Size(379, 70);
            navDashboard.TabIndex = 0;
            // 
            // navTransactions
            // 
            navTransactions.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navTransactions.AutoSize = true;
            navTransactions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navTransactions.BackColor = Color.White;
            navTransactions.DisplayIcon = "e000";
            navTransactions.DisplayLabel = "Transactions";
            navTransactions.DownColor = Color.FromArgb(150, 150, 150);
            navTransactions.HoverColor = Color.FromArgb(238, 238, 238);
            navTransactions.IsActive = false;
            navTransactions.Location = new Point(0, 70);
            navTransactions.Margin = new Padding(0);
            navTransactions.MinIconWidth = 64;
            navTransactions.Name = "navTransactions";
            navTransactions.NormalColor = Color.White;
            navTransactions.NormalForeColor = Color.Black;
            navTransactions.Size = new Size(379, 70);
            navTransactions.TabIndex = 1;
            // 
            // navReccurent
            // 
            navReccurent.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navReccurent.AutoSize = true;
            navReccurent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navReccurent.BackColor = Color.White;
            navReccurent.DisplayIcon = "e000";
            navReccurent.DisplayLabel = "BUTTON";
            navReccurent.DownColor = Color.FromArgb(150, 150, 150);
            navReccurent.HoverColor = Color.FromArgb(238, 238, 238);
            navReccurent.IsActive = false;
            navReccurent.Location = new Point(0, 140);
            navReccurent.Margin = new Padding(0);
            navReccurent.MinIconWidth = 64;
            navReccurent.Name = "navReccurent";
            navReccurent.NormalColor = Color.White;
            navReccurent.NormalForeColor = Color.Black;
            navReccurent.Size = new Size(379, 70);
            navReccurent.TabIndex = 2;
            // 
            // navAccounts
            // 
            navAccounts.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navAccounts.AutoSize = true;
            navAccounts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navAccounts.BackColor = Color.White;
            navAccounts.DisplayIcon = "e000";
            navAccounts.DisplayLabel = "BUTTON";
            navAccounts.DownColor = Color.FromArgb(150, 150, 150);
            navAccounts.HoverColor = Color.FromArgb(238, 238, 238);
            navAccounts.IsActive = false;
            navAccounts.Location = new Point(0, 210);
            navAccounts.Margin = new Padding(0);
            navAccounts.MinIconWidth = 64;
            navAccounts.Name = "navAccounts";
            navAccounts.NormalColor = Color.White;
            navAccounts.NormalForeColor = Color.Black;
            navAccounts.Size = new Size(379, 70);
            navAccounts.TabIndex = 3;
            // 
            // navBarButton5
            // 
            navBarButton5.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navBarButton5.AutoSize = true;
            navBarButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navBarButton5.BackColor = Color.White;
            navBarButton5.DisplayIcon = "e000";
            navBarButton5.DisplayLabel = "BUTTON";
            navBarButton5.DownColor = Color.FromArgb(150, 150, 150);
            navBarButton5.HoverColor = Color.FromArgb(238, 238, 238);
            navBarButton5.IsActive = false;
            navBarButton5.Location = new Point(0, 280);
            navBarButton5.Margin = new Padding(0);
            navBarButton5.MinIconWidth = 64;
            navBarButton5.Name = "navBarButton5";
            navBarButton5.NormalColor = Color.White;
            navBarButton5.NormalForeColor = Color.Black;
            navBarButton5.Size = new Size(379, 70);
            navBarButton5.TabIndex = 4;
            // 
            // navBarButton6
            // 
            navBarButton6.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navBarButton6.AutoSize = true;
            navBarButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navBarButton6.BackColor = Color.White;
            navBarButton6.DisplayIcon = "e000";
            navBarButton6.DisplayLabel = "BUTTON";
            navBarButton6.DownColor = Color.FromArgb(150, 150, 150);
            navBarButton6.HoverColor = Color.FromArgb(238, 238, 238);
            navBarButton6.IsActive = false;
            navBarButton6.Location = new Point(0, 350);
            navBarButton6.Margin = new Padding(0);
            navBarButton6.MinIconWidth = 64;
            navBarButton6.Name = "navBarButton6";
            navBarButton6.NormalColor = Color.White;
            navBarButton6.NormalForeColor = Color.Black;
            navBarButton6.Size = new Size(379, 70);
            navBarButton6.TabIndex = 5;
            // 
            // navBarButton7
            // 
            navBarButton7.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navBarButton7.AutoSize = true;
            navBarButton7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navBarButton7.BackColor = Color.White;
            navBarButton7.DisplayIcon = "e000";
            navBarButton7.DisplayLabel = "BUTTON";
            navBarButton7.DownColor = Color.FromArgb(150, 150, 150);
            navBarButton7.HoverColor = Color.FromArgb(238, 238, 238);
            navBarButton7.IsActive = false;
            navBarButton7.Location = new Point(0, 420);
            navBarButton7.Margin = new Padding(0);
            navBarButton7.MinIconWidth = 64;
            navBarButton7.Name = "navBarButton7";
            navBarButton7.NormalColor = Color.White;
            navBarButton7.NormalForeColor = Color.Black;
            navBarButton7.Size = new Size(379, 70);
            navBarButton7.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1264, 657);
            Controls.Add(navBar1);
            Controls.Add(MainContainer);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            draggablePanel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            navBar1.ResumeLayout(false);
            navBar1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;


        private Panel MainContainer;
        private Panel draggablePanel;
        private IconButton iconButton1;
        private NavBar navBar1;
        private NavBarButton navDashboard;
        private NavBarButton navTransactions;
        private NavBarButton navReccurent;
        private NavBarButton navAccounts;
        private NavBarButton navBarButton5;
        private NavBarButton navBarButton6;
        private NavBarButton navBarButton7;
        private GroupBox groupBox2;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label TotalBalanceText;
        private Label label6;
        private Label BalanceLabel;
        private Label label3;
    }
}
