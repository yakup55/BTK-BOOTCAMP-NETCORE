using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Concrete;
using Repositories.Contracts;

namespace BsStoreApi.Controllers
{
    //[ApiController]
    //[Route("api/books")]
    //public class BooksController : ControllerBase
    //{
    //    //readonly iki şekilde kullanılır ya olduğu yerde yada constractırda
    //    private readonly IBookRepository bookRepository;

    //    public BooksController(IBookRepository bookRepository)
    //    {
    //        this.bookRepository = bookRepository;
    //    }
            
    //    [HttpGet]
    //    public IActionResult GetAllBooks()
    //    {
    //        return Ok(bookRepository.GetAll());
    //    }
    //    [HttpGet("getlastbook")]
    //    public IActionResult GetLastBook()
    //    {   
    //        return Ok(bookRepository.GetLastBook());
    //    }
    //    [HttpGet("{id}")]
    //    public IActionResult GetOneBook([FromRoute]int id)
    //    {
    //        var book = bookRepository.Get(x=>x.BookId==id);
    //        return Ok(book);
    //    }
    //    [HttpDelete("{id}")]
    //    public IActionResult GetBookDelete(int id)
    //    {
    //        var book =bookRepository.Get(x=>x.BookId==id);    
    //        bookRepository.Delete(book);
    //        if (book is null)
    //        {
    //            throw new Exception("Geçersiz id ");
    //        }
    //        return NoContent();
    //    }
    //    [HttpPut("{id}")]
    //    public IActionResult GetBookUpdate([FromRoute]int id,[FromBody] Book book)
    //    {
    //        if (id!=book.BookId)
    //        {
    //            throw new Exception("Geçersiz id");
    //        }
    //        var books = bookRepository.Get(x=>x.BookId==id);
    //        books.BookSummary = book.BookSummary;
    //        books.BookTitle = book.BookTitle;
    //        books.BookPrice = book.BookPrice;

    //        bookRepository.Update(books);
           
    //        return Accepted(books);
    //    }


    //    [HttpPost]
    //    public IActionResult CreateBook([FromBody] Book book)
    //    {
    //        bookRepository.Add(book);
    //        return Ok(book);
    //    }
    //}
}
