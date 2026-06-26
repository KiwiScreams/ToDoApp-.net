using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp_final.Models;
using ToDoApp_final.Services;

namespace ToDoApp_final.Forms
{
    public partial class TaskForm : Form
    {
        private readonly TaskService _taskService;
        private readonly int _userId;
        private readonly TaskItem? _task;

        public TaskForm(TaskService taskService, int userId)
        {
            InitializeComponent();

            _taskService = taskService;
            _userId = userId;

            LoadCategories();
            saveBtn.Text = "Add";
        }
        private void LoadCategories()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[]
            {
                "Home",
                "School",
                "Work",
                "Shopping",
                "Sport",
                "Other"
            });
            comboBox1.SelectedIndex = 0;
        }
        private void LoadTask()
        {
            if (_task == null)
                return;

            titleInput.Text = _task.Title;
            descInput.Text = _task.Description;
            comboBox1.Text = _task.Category;
            isDone.Checked = _task.IsCompleted;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string title = titleInput.Text.Trim();
            string? description = descInput.Text.Trim();
            string category = comboBox1.Text;
            bool isCompleted = isDone.Checked;

            bool success;

            if (_task == null)
            {
                success = _taskService.AddTask(
                    _userId,
                    category,
                    title,
                    description);
            }
            else
            {
                success = _taskService.UpdateTask(
                    _task.Id,
                    category,
                    title,
                    description,
                    isCompleted);
            }

            if (!success)
            {
                MessageBox.Show("Could not save task.");
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
