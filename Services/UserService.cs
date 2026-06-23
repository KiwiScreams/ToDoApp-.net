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
        public bool AddUser(string username, string email, string password)
        {
            bool emailExists = _context.Users.Any(user => user.Email == email);

            if (emailExists)
            {
                return false;
            }
            User user = new User
            {
                Username = username,
                Email = email,
                Password = password
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public User? Login(string email, string password)
        {
            return _context.Users
                .FirstOrDefault(user =>
                    user.Email == email &&
                    user.Password == password);
        }
    }
}
