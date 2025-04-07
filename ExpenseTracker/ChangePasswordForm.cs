
namespace ExpenseTracker {
    public partial class ChangePasswordForm : Form {

        public UserManager? userManager { get; set; } = null;
        public ChangePasswordForm(UserManager _userManager) {
            InitializeComponent();

            userManager = _userManager ?? throw new ArgumentNullException(nameof(_userManager));

            tbNewPassword.MouseClick += (s, e) => ResetError(tbNewPassword);
            tbNewPasswordConfirm.MouseClick += (s, e) => ResetError(tbNewPasswordConfirm);
            tbOldPassword.MouseClick += (s, e) => ResetError(tbOldPassword);


            this.Load += ChangePasswordForm_Load;
        }

        private void ResetError(TextBox textBox) {
            textBox.BackColor = SystemColors.Window;
            ErrorBox.Text = "";
            ErrorBox.Visible = false;
            this.Height = 430;
        }


        private void ClearErrorState() {
            tbOldPassword.BackColor = SystemColors.Window;
            tbNewPassword.BackColor = SystemColors.Window;
            tbNewPasswordConfirm.BackColor = SystemColors.Window;
            ErrorBox.Text = "";
            ErrorBox.Visible = false;
            this.Height = 430;
        }

        private void SetError(Control control, string message) {
            control.BackColor = Color.LightCoral;
            ErrorBox.Text = message;
            ErrorBox.Visible = true;
            this.Height = 600;
        }

        private void ChangePasswordForm_Load(object? sender, EventArgs e) {
            this.Text = $"Change Password [ {userManager.LoggedUser.Username} ]";
        }

        private void bCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bUpdatePassword_Click(object sender, EventArgs e) {

            ClearErrorState();

            var user = userManager.LoggedUser;
            var oldPassword = tbOldPassword.Text.Trim();
            var newPassword = tbNewPassword.Text.Trim();
            var newPasswordConfirm = tbNewPasswordConfirm.Text.Trim();


            if (!user.VerifyPassword(oldPassword)) {
                SetError(tbOldPassword, "ERROR: Wrong Password!");
                return;
            }

            var result = userManager.ValidatePassword(newPassword);
            if (result != ValidationResult.Success) {
                string errorMessage = (result == ValidationResult.InvalidFormat)
                    ? "ERROR: Invalid Format"
                    : $"ERROR: {result}";
                SetError(tbNewPassword, errorMessage);
                return;
            }


            if (newPassword != newPasswordConfirm) {
                SetError(tbNewPasswordConfirm, "ERROR: Passwords don't match");
                return;
            }
            if (user.SetPassword(oldPassword, newPassword)) {
                this.DialogResult = DialogResult.OK;
                Close();
            }
          
        }



    }
}
