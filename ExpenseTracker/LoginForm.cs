

namespace ExpenseTracker {



    public partial class LoginForm : Form {

        private readonly UserManager? userManager;


        public bool ImmediateLogin = false;


        public LoginForm(UserManager _userManager, bool isTestMode ) {
            InitializeComponent();

            userManager = _userManager ?? throw new ArgumentNullException(nameof(_userManager));

            tbLoginEmail.MouseClick += (s, e) => ResetError(tbLoginEmail);
            tbPassword.MouseClick += (s, e) => ResetError(tbPassword);
            tbLoginEmail.TextChanged += (s, e) => ResetError(tbLoginEmail);
            tbPassword.TextChanged += (s, e) => ResetError(tbPassword);

            DialogResult = DialogResult.None; // set to determine reason of form closing
            this.FormClosing += (s, e) => { if (this.DialogResult != DialogResult.OK) this.DialogResult = DialogResult.Cancel; };
            
            TestModeLabel.Visible = isTestMode;
            bSkip.Visible = isTestMode;

            this.Height = 380;

        }



        private void SetError(TextBox? textBox, string error) {
            this.Height = 575;
            ErrorBox.Visible = true;
            ErrorBox.Text = error;

            // if we have target to highlight
            if (textBox != null) {
                textBox.BackColor = Color.LightCoral;
                textBox.Focus();
            }
        }


        private void ResetError(TextBox textBox) {
            textBox.BackColor = SystemColors.Window;
            ErrorBox.Text = "";
            ErrorBox.Visible = false;
            this.Height = 380;
        }

        private void bLogin_Click(object sender, EventArgs e) {
            string usernameOrEmail = tbLoginEmail.Text.Trim();
            string password = tbPassword.Text.Trim();


            var result = userManager.Login(usernameOrEmail, password);
            if (result == ValidationResult.Success) {

                this.DialogResult = DialogResult.OK;
                Close();
            }
            else {
                switch (result) {
                    case ValidationResult.WrongLogin:
                        SetError(tbLoginEmail, "ERROR: Wrong username or email");
                        break;

                    case ValidationResult.WrongPassword:
                        SetError(tbPassword, "ERROR: Wrong Password");
                        break;
                    default: break;
                }
            }
        }

        private void bRegister_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm(userManager); // Still pass UserManager for registration
            if (registerForm.ShowDialog() == DialogResult.OK) {
                if (ImmediateLogin) {

                    var result = userManager.Login(registerForm.RegisteredUser);
                    if (result != ValidationResult.Success) {
                        SetError(null, "Can't Authentificate Automatically: " + registerForm.RegisteredUser.DisplayName);
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void bSkip_Click(object sender, EventArgs e) {

            TestModeUserSelectorForm skipForm = new TestModeUserSelectorForm(userManager);
            skipForm.ShowDialog(this);
            if (skipForm.DialogResult == DialogResult.OK) {
                this.DialogResult = DialogResult.OK;
                Close();
            }
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

    }
}
