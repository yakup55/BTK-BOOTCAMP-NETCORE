using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace BsStoreApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class AuthorController : ControllerBase
    //{
    //    private readonly IAuthorRepository authorRepository;

    //    public AuthorController(IAuthorRepository authorRepository)
    //    {
    //        this.authorRepository = authorRepository;
    //    }
    //    [HttpGet]
    //    public IActionResult GetAllAuthor()
    //    {
    //        return Ok(authorRepository.GetAll());
    //    }
    //    [HttpGet("{id}")]
    //    public IActionResult GetOneAuthor([FromRoute]int id)
    //    {
    //        var author = authorRepository.Get(x=>x.AuthorId==id);
    //        return Ok(author);
    //    }
    //    [HttpDelete("{id}")]
    //    public IActionResult GetOneDeleteAuthor([FromRoute]int id)
    //    {
    //        var delete = authorRepository.Get(x=>x.AuthorId==id);
    //        authorRepository.Delete(delete);
    //        if (delete is null)
    //        {
    //            throw new Exception("Geçersiz id ");
    //        }
    //        return NoContent();
    //    }
    //    [HttpPost]
    //    public IActionResult GetOneAddAuthor([FromBody]Author author)
    //    {
    //        authorRepository.Add(author);
    //        return NoContent();
    //    }
    //    [HttpPut("{id}")]
    //    public IActionResult GetOneUpdateAuthor([FromRoute]int id, [FromBody] Author author)
    //    {
    //        var update = authorRepository.Get(x=>x.AuthorId==id);
    //        update.AuthorFirstName = author.AuthorFirstName;
    //        update.AuthorLastName = author.AuthorLastName;
    //        authorRepository.Update(update);
    //        return NoContent();
    //    }
    //}
}
