namespace ExpenseTracker
{
    // its just a quick solution, it should be split later to separate contexts
    public enum ValidationResult { Success, WrongPassword, WrongLogin, AccountDontExist, InvalidFormat, AlreadyExist }
    public class UserManager
    {

        [Newtonsoft.Json.JsonProperty]
        private List<User> users;

        [Newtonsoft.Json.JsonIgnore]
        public User? LoggedUser { get; private set; } = null; // Stores the currently logged-in user


        public UserManager()
        {
            users = new List<User>();
        }


        public UserManager(List<User> gUsers)
        {

            if (gUsers == null)
                throw new NullReferenceException("Received not initialized list of users");
            users = gUsers;

        }



        public ValidationResult Register(string displayName, string username, string email, string password)
        {
            if (users.Any(a => a.Username == username))
            {

                return ValidationResult.AlreadyExist;
            }
            if (users.Any(a => a.Email == email))
            {
                return ValidationResult.AlreadyExist;
            }

            // Create and store the new user
            User newUser = new User(displayName, username, email, password);
            users.Add(newUser);


            return ValidationResult.Success;
        }


        // ---- Validation ---------------------------


        public ValidationResult ValidateDisplayName(string displayName)
        {

            if (string.IsNullOrWhiteSpace(displayName) || displayName.Length < 3)
            {

                return ValidationResult.InvalidFormat;
            }
            return ValidationResult.Success;
        }

        public ValidationResult ValidateUsername(string username)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9-_]{4,15}$"))
            {
                return ValidationResult.InvalidFormat;
            }
            if (users.Any(a => a.Username == username))
            {
                return ValidationResult.AlreadyExist;
            }
            return ValidationResult.Success;
        }

        public ValidationResult ValidateEmail(string email)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return ValidationResult.InvalidFormat;

            }
            if (users.Any(a => a.Email == email))
            {
                return ValidationResult.AlreadyExist;
            }
            return ValidationResult.Success;
        }

        public ValidationResult ValidatePassword(string password)
        {


            if (string.IsNullOrEmpty(password) || !System.Text.RegularExpressions.Regex.IsMatch(password, @"^[a-zA-Z0-9-_]{4,15}$"))
            {
                return ValidationResult.InvalidFormat;
            }
            return ValidationResult.Success;

        }

        public User? GetUserByUsername(string username)
        {
            return users.FirstOrDefault(a => a.Username == username);
        }
        public User? GetUserByEmail(string email)
        {
            return users.FirstOrDefault(a => a.Email == email);
        }


        public ValidationResult Authenticate(User user)
        {

            if (user == null || !users.Contains(user))
            {
                return ValidationResult.AccountDontExist;
            }

            LoggedUser = user; // Store the logged-in user


            return ValidationResult.Success;
        }

        public ValidationResult Authenticate(string usernameOrEmail, string password)
        {

            var user = GetUserByUsername(usernameOrEmail);

            user ??= GetUserByEmail(usernameOrEmail);

            if (user == null)
            {
                return ValidationResult.WrongLogin;

            }

            if (!user.VerifyPassword(password))
            {
                return ValidationResult.WrongPassword;
            }
            LoggedUser = user; // Store the logged-in user
            return ValidationResult.Success;
        }

        public void Logout()
        {
            LoggedUser = null;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public bool DeleteUser(string username, out string error)
        {
            User? user = GetUserByUsername(username);
            if (user == null)
            {
                error = "ERROR: User not found.";
                return false;
            }
            users.Remove(user);
            error = "User deleted successfully.";
            return true;
        }




    }
}
