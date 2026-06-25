using Microsoft.Extensions.DependencyInjection;
using System;
using ToDoApp_final.Models;
using ToDoApp_final.Services;


namespace ToDoApp_final.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(_userService);
            registerForm.Show();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string email = registerEmailInput.Text.Trim();
            string password = registerPasswordInput.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Enter your email");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your password");
                return;
            }

            User? user = _userService.Login(email, password);

            if (user == null)
            {
                MessageBox.Show("Incorrect email or password.");
                return;
            }

            HomeForm homeForm = new HomeForm(_userService, user.Id);
            homeForm.Show();

            this.Hide();
        }
    }
}