using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.DataAccess;

namespace ShoppingCart.Service.Infrastructure
{
    public interface ICategory
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int Id);
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void Save();
    }
}