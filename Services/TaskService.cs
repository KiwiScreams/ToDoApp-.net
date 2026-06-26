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
                .Where(task => task.UserId == userId)
                .ToList();
        }
        public bool AddTask(int userId, string category, string title, string? description, bool isCompleted = false)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return false;
            }

            TaskItem task = new TaskItem
            {
                UserId = userId,
                Title = title.Trim(),
                Category = category,
                Description = description?.Trim(),
                IsCompleted = isCompleted
            };

            _context.Tasks.Add(task);
            _context.SaveChanges();

            return true;
        }
        public bool UpdateTask(int taskId, string title, string? description, string category, bool isCompleted)
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

            task.Title = title.Trim();
            task.Description = description?.Trim();
            task.Category = category;
            task.IsCompleted = isCompleted;
            _context.SaveChanges();
            return true;
        }
        public bool DeleteTask(int taskId)
        {
            TaskItem? task = _context.Tasks
                .FirstOrDefault(task => task.Id == taskId);

            if (task == null)
            {
                return false;
            }
            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return true;
        }
        public bool ChangeCompletedStatus(int taskId, bool isCompleted)
        {
            TaskItem? task = _context.Tasks
                .FirstOrDefault(task => task.Id == taskId);

            if (task == null)
            {
                return false;
            }

            task.IsCompleted = isCompleted;
            _context.SaveChanges();
            return true;
        }
    }
}
