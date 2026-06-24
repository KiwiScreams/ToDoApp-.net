using System;

namespace ToDoApp_final.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<TaskItem> Tasks { get; set; } = new();
    }
}
