using ExpenseTracker.Controls;

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
            ViewContainer = new ElementContainer();
            panel1 = new Panel();
            bNavBarToogle = new IconButton();
            ViewNameText = new Label();
            panel2 = new Panel();
            navSettings = new NavBarButton();
            navCharts = new NavBarButton();
            navBudgets = new NavBarButton();
            navAccounts = new NavBarButton();
            navReccurent = new NavBarButton();
            navTransactions = new NavBarButton();
            navDashboard = new NavBarButton();
            NavBar = new NavBar();
            TitleBar = new Panel();
            WindowCaptionText = new Label();
            bMainFormClose = new IconButton();
            bMainFormState = new IconButton();
            bMainFormMinimize = new IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            NavBar.SuspendLayout();
            TitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // ViewContainer
            // 
            ViewContainer.AutoScroll = true;
            ViewContainer.BackColor = Color.FromArgb(241, 241, 241);
            ViewContainer.Dock = DockStyle.Fill;
            ViewContainer.Location = new Point(2, 72);
            ViewContainer.Margin = new Padding(0);
            ViewContainer.Name = "ViewContainer";
            ViewContainer.Size = new Size(742, 448);
            ViewContainer.TabIndex = 7;
            ViewContainer.Load += ViewContainer_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 150, 243);
            panel1.Controls.Add(bNavBarToogle);
            panel1.Controls.Add(ViewNameText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 70);
            panel1.TabIndex = 9;
            // 
            // bNavBarToogle
            // 
            bNavBarToogle.DisplayIcon = "menu";
            bNavBarToogle.DisplayIconSize = 24F;
            bNavBarToogle.FlatStyle = FlatStyle.Flat;
            bNavBarToogle.Font = new Font("Material Symbols Outlined", 24F);
            bNavBarToogle.ForeColor = Color.White;
            bNavBarToogle.Location = new Point(3, 3);
            bNavBarToogle.Name = "bNavBarToogle";
            bNavBarToogle.Padding = new Padding(3, 0, 0, 0);
            bNavBarToogle.Size = new Size(64, 64);
            bNavBarToogle.TabIndex = 13;
            bNavBarToogle.UseVisualStyleBackColor = true;
            bNavBarToogle.Click += bNavBarToogle_Click;
            // 
            // ViewNameText
            // 
            ViewNameText.AutoSize = true;
            ViewNameText.Font = new Font("Segoe UI", 16F);
            ViewNameText.ForeColor = Color.White;
            ViewNameText.Location = new Point(73, 16);
            ViewNameText.Name = "ViewNameText";
            ViewNameText.Size = new Size(228, 37);
            ViewNameText.TabIndex = 11;
            ViewNameText.Text = "<ViewNameText>";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(241, 241, 241);
            panel2.Controls.Add(ViewContainer);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(401, 52);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2, 2, 0, 0);
            panel2.Size = new Size(744, 520);
            panel2.TabIndex = 9;
            // 
            // navSettings
            // 
            navSettings.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navSettings.AutoSize = true;
            navSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navSettings.BackColor = Color.White;
            navSettings.DisplayIcon = "settings";
            navSettings.DisplayLabel = "Settings";
            navSettings.DownColor = Color.FromArgb(150, 150, 150);
            navSettings.HoverColor = Color.FromArgb(238, 238, 238);
            navSettings.IsActive = false;
            navSettings.Location = new Point(0, 422);
            navSettings.Margin = new Padding(0);
            navSettings.MinIconWidth = 64;
            navSettings.Name = "navSettings";
            navSettings.NormalColor = Color.White;
            navSettings.NormalForeColor = Color.Black;
            navSettings.Size = new Size(399, 70);
            navSettings.TabIndex = 6;
            // 
            // navCharts
            // 
            navCharts.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navCharts.AutoSize = true;
            navCharts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navCharts.BackColor = Color.White;
            navCharts.DisplayIcon = "bar_chart";
            navCharts.DisplayLabel = "Charts";
            navCharts.DownColor = Color.FromArgb(150, 150, 150);
            navCharts.HoverColor = Color.FromArgb(238, 238, 238);
            navCharts.IsActive = false;
            navCharts.Location = new Point(0, 352);
            navCharts.Margin = new Padding(0);
            navCharts.MinIconWidth = 64;
            navCharts.Name = "navCharts";
            navCharts.NormalColor = Color.White;
            navCharts.NormalForeColor = Color.Black;
            navCharts.Size = new Size(399, 70);
            navCharts.TabIndex = 5;
            // 
            // navBudgets
            // 
            navBudgets.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navBudgets.AutoSize = true;
            navBudgets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navBudgets.BackColor = Color.White;
            navBudgets.DisplayIcon = "timelapse";
            navBudgets.DisplayLabel = "Budgets";
            navBudgets.DownColor = Color.FromArgb(150, 150, 150);
            navBudgets.HoverColor = Color.FromArgb(238, 238, 238);
            navBudgets.IsActive = false;
            navBudgets.Location = new Point(0, 282);
            navBudgets.Margin = new Padding(0);
            navBudgets.MinIconWidth = 64;
            navBudgets.Name = "navBudgets";
            navBudgets.NormalColor = Color.White;
            navBudgets.NormalForeColor = Color.Black;
            navBudgets.Size = new Size(399, 70);
            navBudgets.TabIndex = 4;
            // 
            // navAccounts
            // 
            navAccounts.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navAccounts.AutoSize = true;
            navAccounts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navAccounts.BackColor = Color.White;
            navAccounts.DisplayIcon = "account_balance";
            navAccounts.DisplayLabel = "Accounts";
            navAccounts.DownColor = Color.FromArgb(150, 150, 150);
            navAccounts.HoverColor = Color.FromArgb(238, 238, 238);
            navAccounts.IsActive = false;
            navAccounts.Location = new Point(0, 212);
            navAccounts.Margin = new Padding(0);
            navAccounts.MinIconWidth = 64;
            navAccounts.Name = "navAccounts";
            navAccounts.NormalColor = Color.White;
            navAccounts.NormalForeColor = Color.Black;
            navAccounts.Size = new Size(399, 70);
            navAccounts.TabIndex = 3;
            // 
            // navReccurent
            // 
            navReccurent.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navReccurent.AutoSize = true;
            navReccurent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navReccurent.BackColor = Color.White;
            navReccurent.DisplayIcon = "update";
            navReccurent.DisplayLabel = "Reccurent Transactions";
            navReccurent.DownColor = Color.FromArgb(150, 150, 150);
            navReccurent.HoverColor = Color.FromArgb(238, 238, 238);
            navReccurent.IsActive = false;
            navReccurent.Location = new Point(0, 142);
            navReccurent.Margin = new Padding(0);
            navReccurent.MinIconWidth = 64;
            navReccurent.Name = "navReccurent";
            navReccurent.NormalColor = Color.White;
            navReccurent.NormalForeColor = Color.Black;
            navReccurent.Size = new Size(399, 70);
            navReccurent.TabIndex = 2;
            // 
            // navTransactions
            // 
            navTransactions.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navTransactions.AutoSize = true;
            navTransactions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navTransactions.BackColor = Color.White;
            navTransactions.DisplayIcon = "sync_alt";
            navTransactions.DisplayLabel = "Transactions";
            navTransactions.DownColor = Color.FromArgb(150, 150, 150);
            navTransactions.HoverColor = Color.FromArgb(238, 238, 238);
            navTransactions.IsActive = false;
            navTransactions.Location = new Point(0, 72);
            navTransactions.Margin = new Padding(0);
            navTransactions.MinIconWidth = 64;
            navTransactions.Name = "navTransactions";
            navTransactions.NormalColor = Color.White;
            navTransactions.NormalForeColor = Color.Black;
            navTransactions.Size = new Size(399, 70);
            navTransactions.TabIndex = 1;
            navTransactions.Load += navTransactions_Load;
            // 
            // navDashboard
            // 
            navDashboard.ActiveForeColor = Color.FromArgb(33, 150, 243);
            navDashboard.AutoSize = true;
            navDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navDashboard.BackColor = Color.White;
            navDashboard.DisplayIcon = "dashboard";
            navDashboard.DisplayLabel = "Dashboard";
            navDashboard.DownColor = Color.FromArgb(150, 150, 150);
            navDashboard.HoverColor = Color.FromArgb(238, 238, 238);
            navDashboard.IsActive = false;
            navDashboard.Location = new Point(0, 2);
            navDashboard.Margin = new Padding(0);
            navDashboard.MinIconWidth = 64;
            navDashboard.Name = "navDashboard";
            navDashboard.NormalColor = Color.White;
            navDashboard.NormalForeColor = Color.Black;
            navDashboard.Size = new Size(399, 70);
            navDashboard.TabIndex = 0;
            // 
            // NavBar
            // 
            NavBar.AutoScroll = true;
            NavBar.BackColor = Color.White;
            NavBar.Buttons.Add(navDashboard);
            NavBar.Buttons.Add(navTransactions);
            NavBar.Buttons.Add(navReccurent);
            NavBar.Buttons.Add(navAccounts);
            NavBar.Buttons.Add(navBudgets);
            NavBar.Buttons.Add(navCharts);
            NavBar.Buttons.Add(navSettings);
            NavBar.Controls.Add(navDashboard);
            NavBar.Controls.Add(navTransactions);
            NavBar.Controls.Add(navReccurent);
            NavBar.Controls.Add(navAccounts);
            NavBar.Controls.Add(navBudgets);
            NavBar.Controls.Add(navCharts);
            NavBar.Controls.Add(navSettings);
            NavBar.Dock = DockStyle.Left;
            NavBar.FlowDirection = FlowDirection.TopDown;
            NavBar.Location = new Point(2, 52);
            NavBar.MinimumSize = new Size(50, 50);
            NavBar.Name = "NavBar";
            NavBar.Padding = new Padding(0, 2, 0, 0);
            NavBar.Size = new Size(399, 520);
            NavBar.TabIndex = 6;
            NavBar.WrapContents = false;
            NavBar.ButtonClicked += NavBar_ButtonClicked;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.BackColor = Color.FromArgb(10, 49, 82);
            TitleBar.Controls.Add(WindowCaptionText);
            TitleBar.Controls.Add(bMainFormClose);
            TitleBar.Controls.Add(bMainFormState);
            TitleBar.Controls.Add(bMainFormMinimize);
            TitleBar.Location = new Point(2, 3);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(1143, 48);
            TitleBar.TabIndex = 16;
            // 
            // WindowCaptionText
            // 
            WindowCaptionText.AutoSize = true;
            WindowCaptionText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WindowCaptionText.ForeColor = Color.WhiteSmoke;
            WindowCaptionText.Location = new Point(16, 11);
            WindowCaptionText.Name = "WindowCaptionText";
            WindowCaptionText.Size = new Size(222, 28);
            WindowCaptionText.TabIndex = 10;
            WindowCaptionText.Text = "Personal Finance Tracker";
            // 
            // bMainFormClose
            // 
            bMainFormClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bMainFormClose.BackColor = Color.FromArgb(10, 49, 82);
            bMainFormClose.DisplayIcon = "close";
            bMainFormClose.DisplayIconSize = 12F;
            bMainFormClose.FlatStyle = FlatStyle.Flat;
            bMainFormClose.Font = new Font("Material Symbols Outlined", 12F);
            bMainFormClose.ForeColor = Color.White;
            bMainFormClose.Location = new Point(1095, 0);
            bMainFormClose.Margin = new Padding(0);
            bMainFormClose.Name = "bMainFormClose";
            bMainFormClose.Padding = new Padding(3, 0, 0, 0);
            bMainFormClose.Size = new Size(48, 48);
            bMainFormClose.TabIndex = 13;
            bMainFormClose.UseVisualStyleBackColor = false;
            // 
            // bMainFormState
            // 
            bMainFormState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bMainFormState.BackColor = Color.FromArgb(10, 49, 82);
            bMainFormState.DisplayIcon = "collapse_content";
            bMainFormState.DisplayIconSize = 12F;
            bMainFormState.FlatStyle = FlatStyle.Flat;
            bMainFormState.Font = new Font("Material Symbols Outlined", 12F);
            bMainFormState.ForeColor = Color.White;
            bMainFormState.Location = new Point(1046, 0);
            bMainFormState.Margin = new Padding(0);
            bMainFormState.Name = "bMainFormState";
            bMainFormState.Padding = new Padding(3, 0, 0, 0);
            bMainFormState.Size = new Size(48, 48);
            bMainFormState.TabIndex = 13;
            bMainFormState.UseVisualStyleBackColor = false;
            // 
            // bMainFormMinimize
            // 
            bMainFormMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bMainFormMinimize.BackColor = Color.FromArgb(10, 49, 82);
            bMainFormMinimize.DisplayIcon = "minimize";
            bMainFormMinimize.DisplayIconSize = 12F;
            bMainFormMinimize.FlatStyle = FlatStyle.Flat;
            bMainFormMinimize.Font = new Font("Material Symbols Outlined", 12F);
            bMainFormMinimize.ForeColor = Color.White;
            bMainFormMinimize.Location = new Point(997, 0);
            bMainFormMinimize.Margin = new Padding(0);
            bMainFormMinimize.Name = "bMainFormMinimize";
            bMainFormMinimize.Padding = new Padding(3, 0, 0, 0);
            bMainFormMinimize.Size = new Size(48, 48);
            bMainFormMinimize.TabIndex = 13;
            bMainFormMinimize.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1147, 574);
            Controls.Add(TitleBar);
            Controls.Add(panel2);
            Controls.Add(NavBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Padding = new Padding(2, 52, 2, 2);
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            NavBar.ResumeLayout(false);
            NavBar.PerformLayout();
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ElementContainer ViewContainer;
        private Panel panel1;
        private Panel panel2;
        private Label ViewNameText;
   
        private IconButton bNavBarToogle;
        private NavBarButton navSettings;
        private NavBarButton navCharts;
        private NavBarButton navBudgets;
        private NavBarButton navAccounts;
        private NavBarButton navReccurent;
        private NavBarButton navTransactions;
        private NavBarButton navDashboard;
        private NavBar NavBar;
        private Panel TitleBar;
        public Label WindowCaptionText;
        private IconButton bMainFormClose;
        private IconButton bMainFormState;
        private IconButton bMainFormMinimize;
    }
}
