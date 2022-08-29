using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository:IEntityRepository<Book>
    {
       List<Book> GetLastBook();
        List<Book> GetAllBooksWithDetails();
        //List<Book> GetAllBooksList();
        //Book GetOneBook(int id);
        //void DeleteBook(Book book);
        //void UpdateBook(int id,Book book);
        //void AddBook(Book book);

    }
}
