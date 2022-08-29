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
    public class EfAuthorRepository : EfBaseRepository<Author>, IAuthorRepository
    {
        private readonly AppDbContext context;

        public EfAuthorRepository(AppDbContext context) : base(context)
        {

        }




        //public void AddAuthor(Author author)
        //{
        //    context.Add(author);
        //    context.SaveChanges();
        //}

        //public void DeleteAuthor(Author author)
        //{
        //    context.Remove(author);
        //    context.SaveChanges();
        //}

        //public List<Author> GetAllAthurList()
        //{
        //    return context.Authors.ToList();
        //}

        //public Author GetOneAuthor(int id)
        //{
        //    return context.Authors.Where(x => x.AuthorId == id).SingleOrDefault();
        //}

        //public void UpdateAuthor(Author author)
        //{
        //    context.Update(author);
        //    context.SaveChanges();
        //}
    }
}
