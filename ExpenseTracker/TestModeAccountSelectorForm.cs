

namespace ExpenseTracker {
    public partial class TestModeUserSelectorForm : Form {
        UserManager? userManager = null;

        User? selectedUser = null;
        public TestModeUserSelectorForm(UserManager _userManager) {
            InitializeComponent();

            if (_userManager == null) {
                throw new NullReferenceException("ERROR: User Manager wasn't initialized!");
            }
            this.bConfirm.Click += (s, e) => {
                LogInSelected();
            };

            userManager = _userManager;
            this.Load += TestModeAccountSelectorForm_Load;
        }

        private void LogInSelected() {
            if (selectedUser != null) {

                var result = userManager.Login(selectedUser);

                if (result == ValidationResult.Success) {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else new Exception("ERROR: Possible Version mismatch. User fields may do not satisfy requirements anymore!");
            }
        }

        private void TestModeAccountSelectorForm_Load(object? sender, EventArgs e) {

            lvSelectUser.Visible = true;
            this.Width = 1000;

            // initialize market stocks list
            lvSelectUser.View = View.Details;
            lvSelectUser.FullRowSelect = true;
            lvSelectUser.MultiSelect = false;

            // Add columns
            lvSelectUser.Columns.Add("Display Name", 150);
            lvSelectUser.Columns.Add("Username", 150);
            lvSelectUser.Columns.Add("Email", 250);
            lvSelectUser.SelectedIndexChanged += (e, s) => { TestModeUsersListIndexChanged(); };
            TestModePopulateUsersList();
        }



        private void TestModeUsersListIndexChanged() {

            var index = (lvSelectUser.SelectedIndices.Count > 0) ? lvSelectUser.SelectedIndices[0] : -1; // store

            if (index >= 0) {
                var username = lvSelectUser.Items[index].SubItems[1].Text;
                var user = userManager.GetUserByUsername(username);
                if (user != null) {
                    selectedUser = user;
                }
            }
        }


        private void TestModePopulateUsersList() {
            var index = (lvSelectUser.SelectedIndices.Count > 0) ? lvSelectUser.SelectedIndices[0] : 0; // store

            lvSelectUser.Items.Clear(); // Clear previous entries

            var users = userManager.GetAllUsers();

            foreach (var user in users) {
                ListViewItem item = new ListViewItem(user.DisplayName);
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Email);
                lvSelectUser.Items.Add(item);
            }

            if (index >= 0 && lvSelectUser.Items.Count >= (index + 1)) {
                lvSelectUser.SelectedIndices.Add(index);
            }
        }

        private void lvSelectUser_MouseDoubleClick(object sender, MouseEventArgs e) {
            LogInSelected();
        }
    }
}
