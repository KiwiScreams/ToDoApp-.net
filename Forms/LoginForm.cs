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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = registerUsernameInput.Text.Trim();
            string password = registerPasswordInput.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Enter your name");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your password");
                return;
            }

            User? user = _userService.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
                return;
            }

            //HomeForm homeForm = new HomeForm(user.Username);
            //homeForm.Show();

            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(_userService);
            registerForm.Show();
        }
    }
}