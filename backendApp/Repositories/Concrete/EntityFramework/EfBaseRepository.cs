using Repositories.Concrete.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.EntityFramework
{
    public abstract class EfBaseRepository<T> : IEntityRepository<T> where T : class
    {
        protected readonly AppDbContext context;

        public EfBaseRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).SingleOrDefault();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter is null ?
                context.Set<T>().ToList() :
            context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
