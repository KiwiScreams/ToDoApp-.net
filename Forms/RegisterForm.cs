using System;
using ToDoApp_final.Services;

namespace ToDoApp_final.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;

        public RegisterForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = registerUsernameInput.Text.Trim();
            string password = registerPasswordInput.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            _userService.AddUser(username, password);

            MessageBox.Show("Success");

            registerUsernameInput.Clear();
            registerPasswordInput.Clear();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_userService);
            loginForm.Show();
        }
    }
}
