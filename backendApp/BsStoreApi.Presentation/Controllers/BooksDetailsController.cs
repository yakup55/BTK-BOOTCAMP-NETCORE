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
    [Route("api/books/{id}/bookdetail")]
    public class BooksDetailsController:ControllerBase
    {
        private readonly IBookDetailService bookDetailService;

        public BooksDetailsController(IBookDetailService bookDetailService)
        {
            this.bookDetailService = bookDetailService;
        }
        [HttpGet("{bookId:int}")]
        public IActionResult GetBookDetailByBookId([FromRoute(Name = "bookId")] int bookId)
        {
            return Ok(bookDetailService.GetById(bookId));
        }
    }

}
