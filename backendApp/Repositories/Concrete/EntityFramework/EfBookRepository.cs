using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Concrete.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete.EntityFramework
{
    public class EfBookRepository : EfBaseRepository<Book>, IBookRepository
    {
        public EfBookRepository(AppDbContext context) : base(context)
        {


        }

        public List<Book> GetAllBooksWithDetails()
        {
            return context.Books.Include(x => x.BookDetails).Include(x => x.Category).Include(x => x.BookAuthors).ThenInclude(x => x.Author)
                .ToList();
        }

        public List<Book> GetLastBook()
        {
            return context.Books.OrderByDescending(x => x.BookId).Take(5).ToList();
        }

        //public void AddBook(Book book)
        //{
        //    context.Add(book);
        //    context.SaveChanges();
        //}

        // public void DeleteBook(Book book)
        //{
        //    context.Remove(book);
        //    context.SaveChanges();
        //}

        //public void UpdateBook(int id, Book book)
        //{
        //    var entity = GetOneBook(id);
        //    entity = book;
        //    context.SaveChanges();
        //}
        //public List<Book> GetAllBooksList()
        //{
        //    return context.Books.ToList();
        //}

        //public Book GetOneBook(int id)
        //{
        //    return context.Books.Where(x => x.BookId == id).SingleOrDefault();
        //}


    }
}
