using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Manager
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category AddCategory(Category category)
        {
            if (category is null)
            {
                throw new ArgumentNullException();
            }
            categoryRepository.Add(category);
            return category;
        }

        public void DeleteCategory(int id)
        {
            var delete = GetCategoryById(id);
            if (delete is null)
            {
                throw new Exception();
            }
            categoryRepository.Delete(delete);
        }

        public List<Category> GetAllCategoryList(Expression<Func<Category, bool>> filter = null)
        {
            return categoryRepository.GetAll(filter);
        }

        public Category GetCategoryById(int id)
        {
            var categorys = categoryRepository.Get(x => x.CategoryId == id);
            if (categorys is null)
            {
                throw new Exception();
            }
            return categorys;
        }

        public Category UpdateCategory(Category category, int id)
        {
            if (category.CategoryId != id)
            {
                throw new Exception();
            }
            var categoryentity = GetCategoryById(id);
            categoryentity.CategoryName = category.CategoryName;
            categoryentity.CategoryDescription = category.CategoryDescription;
            categoryRepository.Update(categoryentity);
            return categoryentity;

        }
    }
}

