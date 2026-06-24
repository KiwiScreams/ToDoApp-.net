using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_final.Data;
using ToDoApp_final.Models;

namespace ToDoApp_final.Services
{
    public class CategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public List<Category> GetCategoriesByUserId(int userId)
        {
            return _context.Categories
                .Where(category => category.UserId == userId)
                .ToList();
        }

        public bool AddCategory(int userId, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            bool categoryExists = _context.Categories.Any(category =>
                category.UserId == userId &&
                category.Name == name);

            if (categoryExists)
            {
                return false;
            }

            Category category = new Category
            {
                UserId = userId,
                Name = name
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateCategory(int userId, int categoryId, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            Category? category = _context.Categories.FirstOrDefault(category =>
                category.Id == categoryId &&
                category.UserId == userId);

            if (category == null)
            {
                return false;
            }
            bool categoryNameExists = _context.Categories.Any(otherCategory =>
                otherCategory.UserId == userId &&
                otherCategory.Name == name &&
                otherCategory.Id != categoryId);
            if (categoryNameExists)
            {
                return false;
            }

            category.Name = name;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCategory(int userId, int categoryId)
        {
            Category? category = _context.Categories.FirstOrDefault(category =>
                category.Id == categoryId &&
                category.UserId == userId);

            if (category == null)
            {
                return false;
            }

            bool hasTasks = _context.Tasks.Any(task =>
                task.CategoryId == categoryId &&
                task.UserId == userId);

            if (hasTasks)
            {
                return false;
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return true;
        }

    }
}
