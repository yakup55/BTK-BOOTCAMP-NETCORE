using Entities.Models;
using Repositories.Concrete.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.EntityFramework
{
    public partial class EfCategoryRepository : EfBaseRepository<Category>, ICategoryRepository
    {
        private readonly AppDbContext context;

        public EfCategoryRepository(AppDbContext context) : base(context)
        {

        }
        //public void AddCategory(Category category)
        //{
        //    context.Add(category);
        //    context.SaveChanges();
        //}

        //public void DeleteCategory(Category category)
        //{
        //    context.Remove(category);
        //    context.SaveChanges();
        //}

        //public List<Category> GetAllCategoryList()
        //{
        //    return context.Categories.ToList();
        //}

        //public Category GetOneCategory(int id)
        //{
        //    return context.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
        //}

        //public void UpdateCategory(Category category)
        //{
        //    context.Update(category);
        //    context.SaveChanges();

        //}
    }
}
