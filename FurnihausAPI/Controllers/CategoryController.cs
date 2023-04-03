using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnihausAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("getall")]
        public List<Category> GetAll()
        {
            return _categoryManager.GetAllCategories();
        }

        [HttpGet("getallFeatured")]
        public List<Category> GetAllFeaturedCategories()
        {
            return _categoryManager.GetAllFeaturedCategories();
        }

        [HttpPost("add")]
        public object AddCategory(Category category)
        {
            _categoryManager.Add(category);
            return Ok("Category added.");
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateCategory(Category category, int id)
        {
            _categoryManager.Update(category, id);  
            return Ok(new { status = 200, message = category });
        }

        [HttpDelete("remove/{id}")]
        public IActionResult  DeleteCategory(Category category, int id)
        {
            _categoryManager.Remove(category, id);
            return Ok("Category deleted.");
        }

    }
}
