using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsStoreApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(bookService.GetAllBooksList());
        }
        [HttpGet("{id}")]
        public IActionResult GetOneBook([FromRoute(Name ="id")] int id)
        {
            var book = bookService.GetBookById(id);
            return Ok(book);
        }
        [HttpPost]
        public IActionResult CreateBook([FromBody] Book book)
        {
            bookService.AddBook(book);
            return Ok(book);
        }
        [HttpDelete("{id}")]
        public IActionResult GetBookDelete([FromRoute(Name ="id")] int id)
        {
            bookService.DeleteBook(id);
           
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult GetBookUpdate([FromRoute] int id, [FromBody] Book book)
        {
            return Accepted(bookService.UpdateBook(book,id));
        }
        //[HttpGet("getlastbook")]
        //public IActionResult GetLastBook([FromQuery] int numberofbooks)
        //{
        //    return Ok(bookService.GetLastBook(numberofbooks));
        //}
        [HttpGet("getallbookswithdetails")]
        public IActionResult GetAllBooksWithDetails()
        {
return Ok(bookService.GetAllBooksWithDetails());
        }
    }
}
