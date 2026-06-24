using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ToDoApp_final.Models;
using ToDoApp_final.Data;

namespace ToDoApp_final.Services
{
    public class TaskService
    {
        private readonly AppDbContext _context;
        public TaskService(AppDbContext context)
        {
            _context = context;
        }
        public List<TaskItem> GetTasksByUserId(int userId)
        {
            return _context.Tasks
                .Include(task => task.Category)
                .Where(task => task.UserId == userId)
                .ToList();
        }
        public bool AddTask(int userId, int categoryId, string title, string? description)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return false;
            }

            TaskItem task = new TaskItem
            {
                UserId = userId,
                CategoryId = categoryId,
                Title = title,
                Description = description,
                IsCompleted = false
            };
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateTask(int taskId, string title, string? description, int categoryId)
        {
            TaskItem? task = _context.Tasks
                .FirstOrDefault(task => task.Id == taskId);

            if (task == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                return false;
            }

            task.Title = title;
            task.Description = description;
            task.CategoryId = categoryId;
            _context.SaveChanges();
            return true;
        }
    }
}
