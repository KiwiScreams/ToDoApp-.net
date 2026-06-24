using System;

namespace ToDoApp_final.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<TaskItem> Tasks { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
    }
}
