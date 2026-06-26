using System;
using Microsoft.Extensions.DependencyInjection;
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
            string email = registerEmailInput.Text.Trim();
            string password = registerPasswordInput.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter your username");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Enter your email");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter correct email");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your password");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
                return;
            }

            bool success = _userService.AddUser(username, email, password);

            if (!success)
            {
                MessageBox.Show("User with this email already exists");
                return;
            }

            MessageBox.Show("Registration successful");

            registerUsernameInput.Clear();
            registerEmailInput.Clear();
            registerPasswordInput.Clear();

            this.Hide();

            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();
        }
    }
}
