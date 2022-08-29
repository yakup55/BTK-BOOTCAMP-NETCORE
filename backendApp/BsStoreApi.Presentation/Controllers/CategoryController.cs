using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryservice;

        public CategoryController(ICategoryService categoryservice)
        {
            this.categoryservice = categoryservice;
        }

        [HttpGet]
        public IActionResult GetAllCategory()
        {
            return Ok(categoryservice.GetAllCategoryList());
        }
        [HttpGet("{id}")]
        public IActionResult GetOneCategory([FromRoute] int id)
        {
            var category = categoryservice.GetCategoryById(id);
          
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult GetDeleteCategory([FromRoute] int id)
        {
         
            categoryservice.DeleteCategory(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult GetCategoryUpdate([FromRoute] int id, [FromBody] Category category)
        {
            return Accepted(categoryservice.UpdateCategory(category, id));
        }
        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category category)
        {
            categoryservice.AddCategory(category);
            return Ok(category);
        }
    }
}
