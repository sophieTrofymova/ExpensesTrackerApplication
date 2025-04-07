

namespace ExpenseTracker {
    public partial class RegisterForm : Form {

        private readonly UserManager _userManager;
        public User? RegisteredUser = null;

        public RegisterForm(UserManager userManager) {
            InitializeComponent();
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));


            tbEmail.MouseClick += (s, e) => ResetError(s ?? tbEmail);
            tbUsername.MouseClick += (s, e) => ResetError(s ?? tbUsername);
            tbPassword.MouseClick += (s, e) => ResetError(s ?? tbPassword);
            tbConfirmPassword.MouseClick += (s, e) => ResetError(s ?? tbConfirmPassword);


            tbEmail.TextChanged += (s, e) => ResetError(s ?? tbEmail);
            tbUsername.TextChanged += (s, e) => ResetError(s ?? tbUsername);
            tbPassword.TextChanged += (s, e) => ResetError(s ?? tbPassword);
            tbConfirmPassword.TextChanged += (s, e) => ResetError(s ?? tbConfirmPassword);

            this.Height = 490;

        }


        private void ResetError(object? sender) {
            if (sender is TextBox textBox) {
                textBox.BackColor = SystemColors.Window;
                this.Height = 490;
                ErrorBox.Visible = false;
                ErrorBox.Text = "";
            }
        }

        private void SetError(TextBox textBox, string error) {
            this.Height = 645;
            ErrorBox.Visible = true;
            ErrorBox.Text = error;
            textBox.BackColor = Color.LightCoral;
            textBox.Focus();
        }

        private void bBackToLogin_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bRegister_Click(object sender, EventArgs e) {

            string error = "";

            string username = tbUsername.Text.Trim();
            ValidationResult result = _userManager.ValidateUsername(username);
            if (result != ValidationResult.Success) {

                switch (result) {
                    case ValidationResult.AlreadyExist:
                        error = "ERROR: Username already in use";
                        break;
                    case ValidationResult.InvalidFormat:
                        error = "ERROR: Username must be 4-15 characters long \r\n" +
                            "and contain only letters, numbers, - or _.";
                        break;
                    default:
                        error = result.ToString();
                        break;
                }

                SetError(tbUsername, error);
                return;
            }

            string email = tbEmail.Text.Trim();


            result = _userManager.ValidateEmail(tbEmail.Text.Trim());
            if (result != ValidationResult.Success) {

                switch (result) {
                    case ValidationResult.AlreadyExist:
                        error = "ERROR: Email already in use";
                        break;
                    case ValidationResult.InvalidFormat:
                        error = "ERROR: Invalid Email Format";
                        break;
                    default:
                        error = result.ToString();
                        break;
                }

                SetError(tbEmail, error);
                return;
            }






            string password = tbPassword.Text.Trim();



            result = _userManager.ValidatePassword(password);
            if (result != ValidationResult.Success) {

                switch (result) {
                    case ValidationResult.InvalidFormat:
                        error = "ERROR: Invalid Password Format\r\n\r\n";

                        error += "Password Requirements:\r\n";
                        error += "Your password must meet the following criteria:\r\n";
                        error += "✅ 4 to 15 characters long\r\n";
                        error += "✅ Can contain letters (A-Z, a-z), numbers (0-9), hyphens (-), and underscores (_)\r\n";
                        error += "❌ No special characters like !@#$%^&*()\r\n";
                        error += "❌ No spaces\r\n";
                        break;
                    default:
                        error = result.ToString();
                        break;
                }




                SetError(tbPassword, error);
                return;
            }


            if (tbPassword.Text.Trim() != tbConfirmPassword.Text.Trim()) {
                ErrorBox.Text = "Passwords do not match!";
                tbPassword.BackColor = Color.LightCoral;
                tbConfirmPassword.BackColor = Color.LightCoral;
                tbConfirmPassword.Focus();
                return;
            }


            result = _userManager.Register("New User", username, email, password);
            if (result != ValidationResult.Success) {
                MessageBox.Show(error, "Registration Failed with Error: " + result.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            RegisteredUser = _userManager.GetUserByEmail(email);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bTooglePasswordVisibility_Click(object sender, EventArgs e) {



            if (tbPassword.UseSystemPasswordChar) {
                tbPassword.UseSystemPasswordChar = false;
                bTooglePasswordVisibility.BackColor = Color.LightGreen;
                bTooglePasswordVisibility.Text = "👁";
            }
            else {
                tbPassword.UseSystemPasswordChar = true;
                bTooglePasswordVisibility.BackColor = Color.SandyBrown;
                bTooglePasswordVisibility.Text = "🔒";
            }


        }

        private void bToogleRepeatPasswordVisibility_Click(object sender, EventArgs e) {
            if (tbConfirmPassword.UseSystemPasswordChar) {
                tbConfirmPassword.UseSystemPasswordChar = false;
                bToogleConfirmPasswordVisibility.BackColor = Color.LightGreen;
                bToogleConfirmPasswordVisibility.Text = "👁";
            }
            else {
                tbConfirmPassword.UseSystemPasswordChar = true;
                bToogleConfirmPasswordVisibility.BackColor = Color.SandyBrown;
                bToogleConfirmPasswordVisibility.Text = "🔒";
            }
        }
    }
}
