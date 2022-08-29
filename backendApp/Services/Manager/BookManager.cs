using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Entities.Exceptions.NotFoundException;

namespace Services.Manager
{
    public class BookManager : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book AddBook(Book book)
        {
            if (book is null)
            {
                throw new ArgumentNullException();

            }
            bookRepository.Add(book);
            return book;
        }

        public void DeleteBook(int id)
        {
            var delete = GetBookById(id);
            bookRepository.Delete(delete);
        }

        public List<Book> GetAllBooksList(Expression<Func<Book, bool>> filter = null)
        {
            return bookRepository.GetAll(filter);
        }

        public List<Book> GetAllBooksWithDetails()
        {
            return bookRepository.GetAllBooksWithDetails();
        }

        public Book GetBookById(int id)
        {
            var book = bookRepository.Get(x => x.BookId == id);
            if (book == null)
            {
                throw new BookNotFoundException(id);
            }
            return book;
        }

        //public List<Book> GetLastBook(int x)
        //{
        //    return bookRepository.GetLastBook(x);
        //}

        public Book  UpdateBook(Book book, int id)
        {
            if (book.BookId != id)
            {
                throw new BookNotFoundException(id);
            }
            var bookentity =GetBookById(id);
            bookentity.BookPrice = book.BookPrice;
            bookentity.BookAtCreated = book.BookAtCreated;
            bookentity.BookTitle = book.BookTitle;
            bookentity.BookSummary = book.BookSummary;
            bookRepository.Update(bookentity);
            return bookentity;
        }
    }
}
