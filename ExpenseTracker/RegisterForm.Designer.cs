namespace ExpenseTracker {
    partial class RegisterForm {
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
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            ConfirmInputLabel = new Label();
            PasswordInputLabel = new Label();
            EmailInputLabel = new Label();
            tbConfirmPassword = new TextBox();
            tbPassword = new TextBox();
            UsernameInputLabel = new Label();
            gbRegister = new GroupBox();
            bToogleConfirmPasswordVisibility = new Button();
            bTooglePasswordVisibility = new Button();
            bBackToLogin = new Button();
            bRegister = new Button();
            ErrorBox = new TextBox();
            gbRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(46, 150);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(305, 34);
            tbEmail.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(46, 80);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(305, 34);
            tbUsername.TabIndex = 1;
            // 
            // ConfirmInputLabel
            // 
            ConfirmInputLabel.AutoSize = true;
            ConfirmInputLabel.Location = new Point(24, 258);
            ConfirmInputLabel.Name = "ConfirmInputLabel";
            ConfirmInputLabel.Size = new Size(172, 28);
            ConfirmInputLabel.TabIndex = 6;
            ConfirmInputLabel.Text = "Confirm Password:";
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Location = new Point(24, 188);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(97, 28);
            PasswordInputLabel.TabIndex = 7;
            PasswordInputLabel.Text = "Password:";
            // 
            // EmailInputLabel
            // 
            EmailInputLabel.AutoSize = true;
            EmailInputLabel.Location = new Point(24, 118);
            EmailInputLabel.Name = "EmailInputLabel";
            EmailInputLabel.Size = new Size(68, 28);
            EmailInputLabel.TabIndex = 8;
            EmailInputLabel.Text = "Email: ";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(46, 290);
            tbConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(305, 34);
            tbConfirmPassword.TabIndex = 4;
            tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(46, 220);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(305, 34);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // UsernameInputLabel
            // 
            UsernameInputLabel.AutoSize = true;
            UsernameInputLabel.Location = new Point(24, 48);
            UsernameInputLabel.Name = "UsernameInputLabel";
            UsernameInputLabel.Size = new Size(108, 28);
            UsernameInputLabel.TabIndex = 9;
            UsernameInputLabel.Text = "Username: ";
            // 
            // gbRegister
            // 
            gbRegister.BackColor = Color.Gainsboro;
            gbRegister.Controls.Add(bToogleConfirmPasswordVisibility);
            gbRegister.Controls.Add(bTooglePasswordVisibility);
            gbRegister.Controls.Add(bBackToLogin);
            gbRegister.Controls.Add(bRegister);
            gbRegister.Controls.Add(UsernameInputLabel);
            gbRegister.Controls.Add(tbEmail);
            gbRegister.Controls.Add(tbPassword);
            gbRegister.Controls.Add(tbUsername);
            gbRegister.Controls.Add(tbConfirmPassword);
            gbRegister.Controls.Add(ConfirmInputLabel);
            gbRegister.Controls.Add(EmailInputLabel);
            gbRegister.Controls.Add(PasswordInputLabel);
            gbRegister.Location = new Point(15, 25);
            gbRegister.Margin = new Padding(0);
            gbRegister.Name = "gbRegister";
            gbRegister.Padding = new Padding(5, 15, 5, 5);
            gbRegister.Size = new Size(412, 402);
            gbRegister.TabIndex = 10;
            gbRegister.TabStop = false;
            gbRegister.Text = "Register";
            // 
            // bToogleConfirmPasswordVisibility
            // 
            bToogleConfirmPasswordVisibility.BackColor = Color.SandyBrown;
            bToogleConfirmPasswordVisibility.FlatStyle = FlatStyle.Flat;
            bToogleConfirmPasswordVisibility.Font = new Font("Segoe UI", 10F);
            bToogleConfirmPasswordVisibility.ForeColor = SystemColors.ActiveCaptionText;
            bToogleConfirmPasswordVisibility.Location = new Point(358, 290);
            bToogleConfirmPasswordVisibility.Margin = new Padding(4);
            bToogleConfirmPasswordVisibility.Name = "bToogleConfirmPasswordVisibility";
            bToogleConfirmPasswordVisibility.Size = new Size(34, 34);
            bToogleConfirmPasswordVisibility.TabIndex = 8;
            bToogleConfirmPasswordVisibility.Text = "🔒";
            bToogleConfirmPasswordVisibility.UseVisualStyleBackColor = false;
            bToogleConfirmPasswordVisibility.Click += bToogleRepeatPasswordVisibility_Click;
            // 
            // bTooglePasswordVisibility
            // 
            bTooglePasswordVisibility.BackColor = Color.SandyBrown;
            bTooglePasswordVisibility.FlatStyle = FlatStyle.Flat;
            bTooglePasswordVisibility.Font = new Font("Segoe UI", 10F);
            bTooglePasswordVisibility.ForeColor = SystemColors.ActiveCaptionText;
            bTooglePasswordVisibility.Location = new Point(358, 220);
            bTooglePasswordVisibility.Margin = new Padding(4);
            bTooglePasswordVisibility.Name = "bTooglePasswordVisibility";
            bTooglePasswordVisibility.Size = new Size(34, 34);
            bTooglePasswordVisibility.TabIndex = 7;
            bTooglePasswordVisibility.Text = "🔒";
            bTooglePasswordVisibility.UseVisualStyleBackColor = false;
            bTooglePasswordVisibility.Click += bTooglePasswordVisibility_Click;
            // 
            // bBackToLogin
            // 
            bBackToLogin.BackColor = SystemColors.ButtonFace;
            bBackToLogin.FlatStyle = FlatStyle.Flat;
            bBackToLogin.Location = new Point(46, 341);
            bBackToLogin.Margin = new Padding(3, 4, 3, 4);
            bBackToLogin.Name = "bBackToLogin";
            bBackToLogin.Size = new Size(115, 42);
            bBackToLogin.TabIndex = 6;
            bBackToLogin.Text = "Back";
            bBackToLogin.UseVisualStyleBackColor = false;
            bBackToLogin.Click += bBackToLogin_Click;
            // 
            // bRegister
            // 
            bRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bRegister.BackColor = SystemColors.ButtonFace;
            bRegister.FlatStyle = FlatStyle.Flat;
            bRegister.Location = new Point(236, 341);
            bRegister.Margin = new Padding(3, 4, 3, 4);
            bRegister.Name = "bRegister";
            bRegister.Size = new Size(115, 42);
            bRegister.TabIndex = 5;
            bRegister.Text = "Register";
            bRegister.UseVisualStyleBackColor = false;
            bRegister.Click += bRegister_Click;
            // 
            // ErrorBox
            // 
            ErrorBox.BackColor = Color.Gainsboro;
            ErrorBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorBox.ForeColor = Color.Red;
            ErrorBox.Location = new Point(15, 451);
            ErrorBox.Multiline = true;
            ErrorBox.Name = "ErrorBox";
            ErrorBox.ScrollBars = ScrollBars.Vertical;
            ErrorBox.Size = new Size(409, 135);
            ErrorBox.TabIndex = 14;
            ErrorBox.Text = "<ERROR TEXT>";
            ErrorBox.Visible = false;
            // 
            // RegisterForm
            // 
            AcceptButton = bRegister;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 598);
            Controls.Add(ErrorBox);
            Controls.Add(gbRegister);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            Padding = new Padding(15, 25, 15, 15);
            Text = "Register new account";
            gbRegister.ResumeLayout(false);
            gbRegister.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbUsername;
        private Label ConfirmInputLabel;
        private Label PasswordInputLabel;
        private Label EmailInputLabel;
        private TextBox tbConfirmPassword;
        private TextBox tbPassword;
        private Label UsernameInputLabel;
        private GroupBox gbRegister;
        private Button bRegister;
        private Button bBackToLogin;
        private Button bToogleConfirmPasswordVisibility;
        private Button bTooglePasswordVisibility;
        private TextBox ErrorBox;
    }
}