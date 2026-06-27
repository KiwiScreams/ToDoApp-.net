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

namespace ToDoApp_final.Forms
{
    public partial class TaskDetailForm : Form
    {
        private readonly TaskItem _task;
        public TaskDetailForm(TaskItem task)
        {
            InitializeComponent();
            _task = task;
            LoadTaskDetails();
        }
        private void LoadTaskDetails()
        {
            titleBox.Text = $"{_task.Title}";
            descBox.Text = string.IsNullOrWhiteSpace(_task.Description)
                ? "No description"
                : $"{_task.Description}";

            catBox.Text = $"{_task.Category ?? "No category"}";
        }
    }
}
