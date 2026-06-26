using Microsoft.Extensions.DependencyInjection;
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
using ToDoApp_final.Models;
using ToDoApp_final.Services;

namespace ToDoApp_final.Forms
{
    public partial class HomeForm : Form
    {
        private readonly UserService _userService;
        private readonly TaskService _taskService;
        private int _userId;

        public HomeForm(UserService userService, TaskService taskService, int userId)
        {
            InitializeComponent();
            _userService = userService;
            _taskService = taskService;
            _userId = userId;

            todoPanel.AllowDrop = true;
            completedPanel.AllowDrop = true;

            todoPanel.DragEnter += TaskPanel_DragEnter;
            completedPanel.DragEnter += TaskPanel_DragEnter;

            todoPanel.DragDrop += TaskPanel_DragDrop;
            completedPanel.DragDrop += TaskPanel_DragDrop;

            LoadUserData();
            LoadTasks();
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

        private void LoadTasks()
        {
            todoPanel.Controls.Clear();
            completedPanel.Controls.Clear();

            var tasks = _taskService.GetTasksByUserId(_userId);

            foreach (var task in tasks)
            {
                Panel taskCard = CreateTaskCard(task);

                if (task.IsCompleted)
                {
                    completedPanel.Controls.Add(taskCard);
                }
                else
                {
                    todoPanel.Controls.Add(taskCard);
                }
            }
        }

        private Panel CreateTaskCard(TaskItem task)
        {
            Panel card = new Panel();
            card.Width = 300;
            card.Height = 140;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Tag = task;

            Label titleLabel = new Label();
            titleLabel.Text = task.Title;
            titleLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            titleLabel.Location = new Point(10, 10);
            titleLabel.Width = 260;
            titleLabel.Height = 25;

            Label descLabel = new Label();
            descLabel.Text = task.Description;
            descLabel.Location = new Point(10, 40);
            descLabel.Width = 260;
            descLabel.Height = 40;

            Label categoryLabel = new Label();
            categoryLabel.Text = $"Category: {task.Category}";
            categoryLabel.Location = new Point(10, 80);
            categoryLabel.Width = 260;
            categoryLabel.Height = 20;

            Button editButton = new Button();
            editButton.Text = "Edit";
            editButton.Location = new Point(10, 105);
            editButton.Width = 80;
            editButton.Click += (sender, e) =>
            {
                TaskForm taskForm = new TaskForm(_taskService, _userId, task);

                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTasks();
                }
            };

            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Location = new Point(100, 105);
            deleteButton.Width = 80;
            deleteButton.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show(
                    "Delete this task?",
                    "Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    _taskService.DeleteTask(task.Id);
                    LoadTasks();
                }
            };

            card.MouseDown += TaskCard_MouseDown;
            titleLabel.MouseDown += TaskCard_MouseDown;
            descLabel.MouseDown += TaskCard_MouseDown;
            categoryLabel.MouseDown += TaskCard_MouseDown;

            card.Controls.Add(titleLabel);
            card.Controls.Add(descLabel);
            card.Controls.Add(categoryLabel);
            card.Controls.Add(editButton);
            card.Controls.Add(deleteButton);

            return card;
        }

        private void TaskCard_MouseDown(object? sender, MouseEventArgs e)
        {
            Control? control = sender as Control;

            Panel? card = control as Panel;

            if (card == null)
            {
                card = control?.Parent as Panel;
            }

            if (card == null)
            {
                return;
            }

            if (card.Tag is not TaskItem)
            {
                return;
            }

            card.DoDragDrop(card, DragDropEffects.Move);
        }

        private void TaskPanel_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(typeof(Panel)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void TaskPanel_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }

            Panel? card = e.Data.GetData(typeof(Panel)) as Panel;

            if (card == null)
            {
                return;
            }

            if (card.Tag is not TaskItem task)
            {
                return;
            }

            bool newStatus = sender == completedPanel;

            _taskService.ChangeCompletedStatus(task.Id, newStatus);

            LoadTasks();
        }
        //
        private void logoutButton_Click(object sender, EventArgs e)
        {
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();
            this.Close();
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            var editAccountForm = Program.ServiceProvider.GetRequiredService<EditAccount>();
            editAccountForm.ShowDialog();

            LoadUserData();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(_taskService, _userId);
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                LoadTasks();
            }
        }
    }
}
