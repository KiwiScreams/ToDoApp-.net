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
        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }
        public bool AddCategory(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            bool categoryExists = _context.Categories.Any(category => category.Name == name);

            if (categoryExists)
            {
                return false;
            }

            Category category = new Category
            {
                Name = name
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateCategory(int categoryId, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            Category? category = _context.Categories
                .FirstOrDefault(category => category.Id == categoryId);
            if (category == null)
            {
                return false;
            }
            bool categoryNameExists = _context.Categories.Any(otherCategory =>
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
        public bool DeleteCategory(int categoryId)
        {
            Category? category = _context.Categories
                .FirstOrDefault(category => category.Id == categoryId);

            if (category == null)
            {
                return false;
            }
            bool hasTasks = _context.Tasks.Any(task => task.CategoryId == categoryId);
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
