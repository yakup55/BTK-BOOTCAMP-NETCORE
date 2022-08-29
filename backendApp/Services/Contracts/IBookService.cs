using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IBookService
    {
        List<Book> GetAllBooksList(Expression<Func<Book,bool>>filter=null);
        Book GetBookById(int id);
        Book AddBook(Book book);
        void DeleteBook(int id);
        Book UpdateBook(Book book,int id);
        //List<Book> GetLastBook(int x);
        List<Book> GetAllBooksWithDetails();
    }
}
