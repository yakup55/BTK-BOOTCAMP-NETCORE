using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Concrete;
using Repositories.Contracts;
using Services.Contracts;

namespace BsStoreApi.Controllers
{
    //[ApiController]
    //[Route("api/controller")]

    //public class CategoryController : ControllerBase
    //{
    //    private readonly ICategoryService categoryservice;

    //    public CategoryController(ICategoryService categoryservice)
    //    {
    //        this.categoryservice = categoryservice;
    //    }

    //    [HttpGet]
    //    public IActionResult GetAllCategory()
    //    {
    //        return Ok(categoryservice.GetAllCategoryList());
    //    }
    //    [HttpGet("{id}")]
    //    public IActionResult GetOneCategory([FromRoute(Name = "id")] int id)
    //    {
    //        var category = categoryservice.GetCategoryById(id);
    //        return Ok(category);
    //    }
    //    [HttpPost]
    //    public IActionResult CreateBook([FromBody] Category category)
    //    {
    //        categoryservice.AddCategory(category);
    //        return Ok(category);
    //    }
    //    [HttpDelete("{id}")]
    //    public IActionResult GetCategoryDelete([FromRoute(Name = "id")] int id)
    //    {
    //        categoryservice.DeleteCategory(id);

    //        return NoContent();
    //    }
    //    [HttpPut("{id}")]
    //    public IActionResult GetBookUpdate([FromRoute] int id, [FromBody] Category category)
    //    {
    //        return Accepted(categoryservice.UpdateCategory(category, id));
    //    }
    //}
}
