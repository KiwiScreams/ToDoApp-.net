using System;
using Microsoft.EntityFrameworkCore;
using ToDoApp_final.Models;
namespace ToDoApp_final.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
    }

}
