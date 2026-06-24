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
    }
}
