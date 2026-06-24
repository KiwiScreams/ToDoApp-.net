using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp_final.Forms;
using ToDoApp_final.Services;
using ToDoApp_final.Models;

namespace ToDoApp_final.Forms
{
    public partial class HomeForm : Form
    {
        private readonly UserService _userService;
        private readonly int _userId;
        public HomeForm(UserService userService, int userId)
        {
            InitializeComponent();
            _userService = userService;
            _userId = userId;
            LoadUserData();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_userService);
            loginForm.Show();
        }
        private void LoadUserData()
        {
            User? user = _userService.GetUserById(_userId);

            if (user == null)
            {
                MessageBox.Show("User not found");
                return;
            }

            usernameLabel.Text = $"Hello, {user.Username}";
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            EditAccount editAccountForm = new EditAccount(_userService, _userId);
            editAccountForm.ShowDialog();

            LoadUserData();
        }
    }
}
