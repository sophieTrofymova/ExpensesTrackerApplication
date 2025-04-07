namespace ExpenseTracker {
    partial class ChangePasswordForm {
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
        private void InitializeComponent() {
            OldPasswordLabel = new Label();
            NewPasswordLabel = new Label();
            ConfirmPasswordLabel = new Label();
            tbOldPassword = new TextBox();
            tbNewPassword = new TextBox();
            tbNewPasswordConfirm = new TextBox();
            bUpdatePassword = new Button();
            bCancel = new Button();
            ErrorBox = new TextBox();
            gbPasswordChange = new GroupBox();
            gbPasswordChange.SuspendLayout();
            SuspendLayout();
            // 
            // OldPasswordLabel
            // 
            OldPasswordLabel.AutoSize = true;
            OldPasswordLabel.Location = new Point(24, 60);
            OldPasswordLabel.Name = "OldPasswordLabel";
            OldPasswordLabel.Size = new Size(130, 28);
            OldPasswordLabel.TabIndex = 0;
            OldPasswordLabel.Text = "Old Password";
            // 
            // NewPasswordLabel
            // 
            NewPasswordLabel.AutoSize = true;
            NewPasswordLabel.Location = new Point(24, 131);
            NewPasswordLabel.Name = "NewPasswordLabel";
            NewPasswordLabel.Size = new Size(137, 28);
            NewPasswordLabel.TabIndex = 0;
            NewPasswordLabel.Text = "New Password";
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(24, 199);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(168, 28);
            ConfirmPasswordLabel.TabIndex = 0;
            ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // tbOldPassword
            // 
            tbOldPassword.Location = new Point(46, 94);
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.Size = new Size(305, 34);
            tbOldPassword.TabIndex = 1;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(46, 162);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(305, 34);
            tbNewPassword.TabIndex = 1;
            // 
            // tbNewPasswordConfirm
            // 
            tbNewPasswordConfirm.Location = new Point(46, 230);
            tbNewPasswordConfirm.Name = "tbNewPasswordConfirm";
            tbNewPasswordConfirm.Size = new Size(305, 34);
            tbNewPasswordConfirm.TabIndex = 1;
            // 
            // bUpdatePassword
            // 
            bUpdatePassword.BackColor = SystemColors.ButtonFace;
            bUpdatePassword.FlatStyle = FlatStyle.Flat;
            bUpdatePassword.Location = new Point(235, 270);
            bUpdatePassword.Name = "bUpdatePassword";
            bUpdatePassword.Size = new Size(116, 42);
            bUpdatePassword.TabIndex = 2;
            bUpdatePassword.Text = "Update";
            bUpdatePassword.UseVisualStyleBackColor = false;
            bUpdatePassword.Click += bUpdatePassword_Click;
            // 
            // bCancel
            // 
            bCancel.BackColor = SystemColors.ButtonFace;
            bCancel.FlatStyle = FlatStyle.Flat;
            bCancel.Location = new Point(46, 270);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(123, 42);
            bCancel.TabIndex = 2;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = false;
            bCancel.Click += bCancel_Click;
            // 
            // ErrorBox
            // 
            ErrorBox.Location = new Point(19, 365);
            ErrorBox.Multiline = true;
            ErrorBox.Name = "ErrorBox";
            ErrorBox.Size = new Size(384, 176);
            ErrorBox.TabIndex = 3;
            ErrorBox.Visible = false;
            // 
            // gbPasswordChange
            // 
            gbPasswordChange.BackColor = Color.Gainsboro;
            gbPasswordChange.Controls.Add(tbNewPassword);
            gbPasswordChange.Controls.Add(OldPasswordLabel);
            gbPasswordChange.Controls.Add(bUpdatePassword);
            gbPasswordChange.Controls.Add(bCancel);
            gbPasswordChange.Controls.Add(NewPasswordLabel);
            gbPasswordChange.Controls.Add(ConfirmPasswordLabel);
            gbPasswordChange.Controls.Add(tbNewPasswordConfirm);
            gbPasswordChange.Controls.Add(tbOldPassword);
            gbPasswordChange.Location = new Point(19, 28);
            gbPasswordChange.Name = "gbPasswordChange";
            gbPasswordChange.Padding = new Padding(5, 15, 5, 5);
            gbPasswordChange.Size = new Size(384, 331);
            gbPasswordChange.TabIndex = 4;
            gbPasswordChange.TabStop = false;
            gbPasswordChange.Text = "Change Password";
            // 
            // ChangePasswordForm
            // 
            ClientSize = new Size(422, 566);
            Controls.Add(gbPasswordChange);
            Controls.Add(ErrorBox);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            Padding = new Padding(15, 25, 15, 15);
            Text = "Change Password";
            gbPasswordChange.ResumeLayout(false);
            gbPasswordChange.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label OldPasswordLabel;
        private Label NewPasswordLabel;
        private Label ConfirmPasswordLabel;
        private TextBox tbOldPassword;
        private TextBox tbNewPassword;
        private TextBox tbNewPasswordConfirm;
        private Button bUpdatePassword;
        private Button bCancel;
        private TextBox ErrorBox;
        private GroupBox gbPasswordChange;
    }
}
