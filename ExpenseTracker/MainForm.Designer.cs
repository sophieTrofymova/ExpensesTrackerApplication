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
            NavBar = new NavBar();
            navDashboard = new NavBarButton();
            navTransactions = new NavBarButton();
            navReccurent = new NavBarButton();
            navAccounts = new NavBarButton();
            navBarButton5 = new NavBarButton();
            navBarButton6 = new NavBarButton();
            navBarButton7 = new NavBarButton();
            navBarButton11 = new NavBarButton();
            navBarButton12 = new NavBarButton();
            ViewContainer = new ElementContainer();
            panel1 = new Panel();
            ViewNameText = new Label();
            bNavBarToogle = new IconButton();
            panel2 = new Panel();
            NavBar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.AutoScroll = true;
            NavBar.BackColor = Color.WhiteSmoke;
            NavBar.Buttons.Add(navDashboard);
            NavBar.Buttons.Add(navTransactions);
            NavBar.Buttons.Add(navReccurent);
            NavBar.Buttons.Add(navAccounts);
            NavBar.Buttons.Add(navBarButton5);
            NavBar.Buttons.Add(navBarButton6);
            NavBar.Buttons.Add(navBarButton7);
            NavBar.Buttons.Add(navBarButton11);
            NavBar.Buttons.Add(navBarButton12);
            NavBar.Controls.Add(navDashboard);
            NavBar.Controls.Add(navTransactions);
            NavBar.Controls.Add(navReccurent);
            NavBar.Controls.Add(navAccounts);
            NavBar.Controls.Add(navBarButton5);
            NavBar.Controls.Add(navBarButton6);
            NavBar.Controls.Add(navBarButton7);
            NavBar.Controls.Add(navBarButton11);
            NavBar.Controls.Add(navBarButton12);
            NavBar.Dock = DockStyle.Left;
            NavBar.FlowDirection = FlowDirection.TopDown;
            NavBar.Location = new Point(0, 0);
            NavBar.MinimumSize = new Size(50, 50);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(429, 574);
            NavBar.TabIndex = 6;
            NavBar.WrapContents = false;
            NavBar.ButtonClicked += NavBar_ButtonClicked;
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
            navDashboard.Size = new Size(405, 70);
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
            navTransactions.Size = new Size(405, 70);
            navTransactions.TabIndex = 1;
            navTransactions.Load += navTransactions_Load;
            // 
            // navReccurent
            // 
            navReccurent.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navReccurent.AutoSize = true;
            navReccurent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navReccurent.BackColor = Color.White;
            navReccurent.DisplayIcon = "e000";
            navReccurent.DisplayLabel = "Reccurent Transactions";
            navReccurent.DownColor = Color.FromArgb(150, 150, 150);
            navReccurent.HoverColor = Color.FromArgb(238, 238, 238);
            navReccurent.IsActive = false;
            navReccurent.Location = new Point(0, 140);
            navReccurent.Margin = new Padding(0);
            navReccurent.MinIconWidth = 64;
            navReccurent.Name = "navReccurent";
            navReccurent.NormalColor = Color.White;
            navReccurent.NormalForeColor = Color.Black;
            navReccurent.Size = new Size(405, 70);
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
            navAccounts.Size = new Size(405, 70);
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
            navBarButton5.Size = new Size(405, 70);
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
            navBarButton6.Size = new Size(405, 70);
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
            navBarButton7.Size = new Size(405, 70);
            navBarButton7.TabIndex = 6;
            // 
            // navBarButton11
            // 
            navBarButton11.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navBarButton11.AutoSize = true;
            navBarButton11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navBarButton11.BackColor = Color.White;
            navBarButton11.DisplayIcon = "e000";
            navBarButton11.DisplayLabel = "BUTTON";
            navBarButton11.DownColor = Color.FromArgb(150, 150, 150);
            navBarButton11.HoverColor = Color.FromArgb(238, 238, 238);
            navBarButton11.IsActive = false;
            navBarButton11.Location = new Point(0, 490);
            navBarButton11.Margin = new Padding(0);
            navBarButton11.MinIconWidth = 64;
            navBarButton11.Name = "navBarButton11";
            navBarButton11.NormalColor = Color.White;
            navBarButton11.NormalForeColor = Color.Black;
            navBarButton11.Size = new Size(405, 70);
            navBarButton11.TabIndex = 14;
            // 
            // navBarButton12
            // 
            navBarButton12.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navBarButton12.AutoSize = true;
            navBarButton12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navBarButton12.BackColor = Color.White;
            navBarButton12.DisplayIcon = "e000";
            navBarButton12.DisplayLabel = "BUTTON";
            navBarButton12.DownColor = Color.FromArgb(150, 150, 150);
            navBarButton12.HoverColor = Color.FromArgb(238, 238, 238);
            navBarButton12.IsActive = false;
            navBarButton12.Location = new Point(0, 560);
            navBarButton12.Margin = new Padding(0);
            navBarButton12.MinIconWidth = 64;
            navBarButton12.Name = "navBarButton12";
            navBarButton12.NormalColor = Color.White;
            navBarButton12.NormalForeColor = Color.Black;
            navBarButton12.Size = new Size(405, 70);
            navBarButton12.TabIndex = 15;
            // 
            // ViewContainer
            // 
            ViewContainer.AutoScroll = true;
            ViewContainer.BackColor = Color.FromArgb(241, 241, 241);
            ViewContainer.Dock = DockStyle.Fill;
            ViewContainer.Location = new Point(5, 75);
            ViewContainer.Margin = new Padding(0);
            ViewContainer.Name = "ViewContainer";
            ViewContainer.Size = new Size(825, 494);
            ViewContainer.TabIndex = 7;
            ViewContainer.Load += ViewContainer_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 150, 243);
            panel1.Controls.Add(ViewNameText);
            panel1.Controls.Add(bNavBarToogle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 70);
            panel1.TabIndex = 9;
            // 
            // ViewNameText
            // 
            ViewNameText.AutoSize = true;
            ViewNameText.Font = new Font("Segoe UI", 16F);
            ViewNameText.ForeColor = Color.White;
            ViewNameText.Location = new Point(105, 16);
            ViewNameText.Name = "ViewNameText";
            ViewNameText.Size = new Size(228, 37);
            ViewNameText.TabIndex = 11;
            ViewNameText.Text = "<ViewNameText>";
            // 
            // bNavBarToogle
            // 
            bNavBarToogle.ActiveForeColor = Color.FromArgb(33, 150, 243);
            bNavBarToogle.AutoSize = true;
            bNavBarToogle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bNavBarToogle.BackColor = Color.White;
            bNavBarToogle.BorderStyle = BorderStyle.FixedSingle;
            bNavBarToogle.DisplayIcon = "e5d2";
            bNavBarToogle.DownColor = Color.FromArgb(150, 150, 150);
            bNavBarToogle.HoverColor = Color.FromArgb(238, 238, 238);
            bNavBarToogle.IconSize = 24;
            bNavBarToogle.IsActive = false;
            bNavBarToogle.Location = new Point(10, 9);
            bNavBarToogle.Margin = new Padding(0);
            bNavBarToogle.Name = "bNavBarToogle";
            bNavBarToogle.NormalColor = Color.White;
            bNavBarToogle.NormalForeColor = Color.Black;
            bNavBarToogle.Size = new Size(64, 52);
            bNavBarToogle.TabIndex = 10;
            bNavBarToogle.Click += bNavBarToogle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Controls.Add(ViewContainer);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(429, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(835, 574);
            panel2.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1264, 574);
            Controls.Add(panel2);
            Controls.Add(NavBar);
            Name = "MainForm";
            Text = "Form1";
            NavBar.ResumeLayout(false);
            NavBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private IconButton iconButton1;
        private NavBar NavBar;
        private NavBarButton navDashboard;
        private NavBarButton navTransactions;
        private NavBarButton navReccurent;
        private NavBarButton navAccounts;
        private NavBarButton navBarButton5;
        private NavBarButton navBarButton6;
        private NavBarButton navBarButton7;
        private NavBarButton navBarButton11;
        private NavBarButton navBarButton12;
        private ElementContainer ViewContainer;
        private Panel panel1;
        private Panel panel2;
        private Label ViewNameText;
        private IconButton bNavBarToogle;
    }
}
