using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface ICategoryRepository:IEntityRepository<Category>
    {
        //List<Category> GetAllCategoryList();
        //void AddCategory(Category category);
        //void UpdateCategory(Category category);
        //void DeleteCategory(Category category);
        //Category GetOneCategory(int id);
    }
}
