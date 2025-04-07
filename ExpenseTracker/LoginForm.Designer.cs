namespace ExpenseTracker {
    partial class LoginForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            TestModeLabel = new Label();
            UsernameInputLabel = new Label();
            tbPassword = new TextBox();
            PasswordInputLabel = new Label();
            tbLoginEmail = new TextBox();
            bLogin = new Button();
            bRegister = new Button();
            bTooglePasswordVisibility = new Button();
            bSkip = new Button();
            gbLogin = new GroupBox();
            ErrorBox = new TextBox();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // TestModeLabel
            // 
            TestModeLabel.AutoSize = true;
            TestModeLabel.Font = new Font("Segoe UI", 12F);
            TestModeLabel.ForeColor = Color.Red;
            TestModeLabel.Location = new Point(83, 0);
            TestModeLabel.Name = "TestModeLabel";
            TestModeLabel.Size = new Size(310, 28);
            TestModeLabel.TabIndex = 5;
            TestModeLabel.Text = "You are currently in the test mode ";
            TestModeLabel.Visible = false;
            // 
            // UsernameInputLabel
            // 
            UsernameInputLabel.AutoSize = true;
            UsernameInputLabel.Location = new Point(24, 60);
            UsernameInputLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameInputLabel.Name = "UsernameInputLabel";
            UsernameInputLabel.Size = new Size(184, 28);
            UsernameInputLabel.TabIndex = 1;
            UsernameInputLabel.Text = "Email or Username: ";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(46, 168);
            tbPassword.Margin = new Padding(4, 6, 4, 6);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(305, 34);
            tbPassword.TabIndex = 0;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Location = new Point(24, 134);
            PasswordInputLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(97, 28);
            PasswordInputLabel.TabIndex = 1;
            PasswordInputLabel.Text = "Password:";
            // 
            // tbLoginEmail
            // 
            tbLoginEmail.Font = new Font("Segoe UI", 12F);
            tbLoginEmail.Location = new Point(46, 94);
            tbLoginEmail.Margin = new Padding(4, 6, 4, 6);
            tbLoginEmail.Name = "tbLoginEmail";
            tbLoginEmail.Size = new Size(305, 34);
            tbLoginEmail.TabIndex = 0;
            // 
            // bLogin
            // 
            bLogin.BackColor = SystemColors.ButtonFace;
            bLogin.FlatStyle = FlatStyle.Flat;
            bLogin.Location = new Point(236, 214);
            bLogin.Margin = new Padding(4, 6, 4, 6);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(115, 42);
            bLogin.TabIndex = 3;
            bLogin.Text = "Login";
            bLogin.UseVisualStyleBackColor = false;
            bLogin.Click += bLogin_Click;
            // 
            // bRegister
            // 
            bRegister.BackColor = SystemColors.ButtonFace;
            bRegister.FlatStyle = FlatStyle.Flat;
            bRegister.Location = new Point(46, 214);
            bRegister.Margin = new Padding(4, 6, 4, 6);
            bRegister.Name = "bRegister";
            bRegister.Size = new Size(115, 42);
            bRegister.TabIndex = 3;
            bRegister.Text = "Register";
            bRegister.UseVisualStyleBackColor = false;
            bRegister.Click += bRegister_Click;
            // 
            // bTooglePasswordVisibility
            // 
            bTooglePasswordVisibility.BackColor = Color.SandyBrown;
            bTooglePasswordVisibility.FlatStyle = FlatStyle.Flat;
            bTooglePasswordVisibility.Font = new Font("Segoe UI", 10F);
            bTooglePasswordVisibility.ForeColor = SystemColors.ActiveCaptionText;
            bTooglePasswordVisibility.Location = new Point(359, 168);
            bTooglePasswordVisibility.Margin = new Padding(4);
            bTooglePasswordVisibility.Name = "bTooglePasswordVisibility";
            bTooglePasswordVisibility.Size = new Size(34, 34);
            bTooglePasswordVisibility.TabIndex = 4;
            bTooglePasswordVisibility.Text = "🔒";
            bTooglePasswordVisibility.UseVisualStyleBackColor = false;
            bTooglePasswordVisibility.Click += bTooglePasswordVisibility_Click;
            // 
            // bSkip
            // 
            bSkip.BackColor = SystemColors.ActiveCaption;
            bSkip.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            bSkip.FlatStyle = FlatStyle.Flat;
            bSkip.Location = new Point(255, 37);
            bSkip.Margin = new Padding(4);
            bSkip.Name = "bSkip";
            bSkip.Size = new Size(96, 42);
            bSkip.TabIndex = 4;
            bSkip.Text = "SKIP";
            bSkip.UseVisualStyleBackColor = false;
            bSkip.Visible = false;
            bSkip.Click += bSkip_Click;
            // 
            // gbLogin
            // 
            gbLogin.BackColor = Color.Gainsboro;
            gbLogin.Controls.Add(TestModeLabel);
            gbLogin.Controls.Add(bSkip);
            gbLogin.Controls.Add(bTooglePasswordVisibility);
            gbLogin.Controls.Add(bRegister);
            gbLogin.Controls.Add(bLogin);
            gbLogin.Controls.Add(tbLoginEmail);
            gbLogin.Controls.Add(PasswordInputLabel);
            gbLogin.Controls.Add(tbPassword);
            gbLogin.Controls.Add(UsernameInputLabel);
            gbLogin.FlatStyle = FlatStyle.Flat;
            gbLogin.Font = new Font("Segoe UI", 12F);
            gbLogin.Location = new Point(15, 25);
            gbLogin.Margin = new Padding(0);
            gbLogin.Name = "gbLogin";
            gbLogin.Padding = new Padding(4, 6, 4, 6);
            gbLogin.Size = new Size(409, 287);
            gbLogin.TabIndex = 2;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            // 
            // ErrorBox
            // 
            ErrorBox.BackColor = Color.Gainsboro;
            ErrorBox.Font = new Font("Segoe UI", 10F);
            ErrorBox.ForeColor = Color.Red;
            ErrorBox.Location = new Point(15, 324);
            ErrorBox.Multiline = true;
            ErrorBox.Name = "ErrorBox";
            ErrorBox.ScrollBars = ScrollBars.Vertical;
            ErrorBox.Size = new Size(409, 187);
            ErrorBox.TabIndex = 3;
            ErrorBox.Text = "<ERROR TEXT>";
            ErrorBox.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 518);
            Controls.Add(ErrorBox);
            Controls.Add(gbLogin);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MaximumSize = new Size(456, 565);
            MinimizeBox = false;
            MinimumSize = new Size(456, 380);
            Name = "LoginForm";
            Padding = new Padding(15, 25, 15, 15);
            Text = "Login into account";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TestModeLabel;
        private Label UsernameInputLabel;
        private TextBox tbPassword;
        private Label PasswordInputLabel;
        private TextBox tbLoginEmail;
        private Button bLogin;
        private Button bRegister;
        private Button bTooglePasswordVisibility;
        private Button bSkip;
        private GroupBox gbLogin;
        private TextBox ErrorBox;
    }
}