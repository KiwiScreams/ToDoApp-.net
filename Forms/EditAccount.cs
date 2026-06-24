using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp_final.Services;
using ToDoApp_final.Models;

namespace ToDoApp_final.Forms
{
    public partial class EditAccount : Form
    {
        private readonly UserService _userService;
        private readonly int _userId;

        public EditAccount(UserService userService, int userId)
        {
            InitializeComponent();
            _userService = userService;
            _userId = userId;

            LoadUserData();
        }
        private void LoadUserData()
        {
            User? user = _userService.GetUserById(_userId);

            if (user == null)
            {
                MessageBox.Show("User not found");
                this.Close();
                return;
            }

            registerUsernameInput.Text = user.Username;
            registerEmailInput.Text = user.Email;
            registerPasswordInput.Text = user.Password;
        }
        private void saveButton_Click(object sender, EventArgs e)
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

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            bool success = _userService.UpdateUser(_userId, username, email, password);

            if (!success)
            {
                MessageBox.Show("This email is already used by another user");
                return;
            }

            MessageBox.Show("Account updated successfully");

            this.Close();
        }
    }
}
