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
    [Route("api/[controller]")]
    public class AuthorController:ControllerBase
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public IActionResult GetAllAuthor()
        {
            return Ok(authorService.GetAllAuthorList());
        }
        [HttpGet("{id}",Name = "GetOneAuthor")]
        public IActionResult GetOneAuthor([FromRoute(Name = "id")] int id)
        {
            var author = authorService.GetById(id);
            return Ok(author);
        }
        [HttpPost]
        public IActionResult CreateAuthor([FromBody] Author author )
        {
           
            authorService.AddAuthor(author);
            return CreatedAtRoute("GetOneAuthor", new { id = author.AuthorId }, author);
        }
        [HttpDelete("{id}")]
        public IActionResult GetAuthorDelete([FromRoute(Name = "id")] int id)
        {
          
            authorService.DeleteAuthor(id);

            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult GetAuthorUpdate( [FromBody] Author author, [FromRoute] int id)
        {
            return Accepted(authorService.UpdateAuthor(author, id));
        }
    }
}
