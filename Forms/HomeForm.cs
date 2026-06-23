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

namespace ToDoApp_final.Forms
{
    public partial class HomeForm : Form
    {
        private readonly UserService _userService;
        private readonly string _username;
        public HomeForm(UserService userService, string username)
        {
            InitializeComponent();
            _userService = userService;
            _username = username;
            usernameLabel.Text = $"{_username}";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_userService);
            loginForm.Show();
        }
    }
}
