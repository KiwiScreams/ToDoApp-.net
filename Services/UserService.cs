using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using ToDoApp_final.Data;
using ToDoApp_final.Models;
namespace ToDoApp_final.Services
{
 
    public class UserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public void AddUser(string username, string password)
        {
            User user = new User
            {
                Username = username,
                Password = password
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
