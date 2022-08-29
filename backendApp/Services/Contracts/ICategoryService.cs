using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        List<Category> GetAllCategoryList(Expression<Func<Category, bool>> filter = null);
        Category GetCategoryById(int id);
        Category AddCategory(Category category);    
        Category UpdateCategory(Category category,int id);
        void DeleteCategory(int id);
    }
}
