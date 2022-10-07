using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;


namespace FurnihausAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogManager _blogManager;

        public BlogController(IBlogManager blogManager)
        {
            _blogManager = blogManager;
        }


        [HttpGet("getall")]
        public List<Blog> GetAll()
        {
            return _blogManager.GetAllBlogs();
        }

        [HttpPost("add")]
        public object AddBlog(AddBlogDTO addBlogDTO)
        {
            _blogManager.AddBlog(addBlogDTO);
            return Ok("Blog added.");
        }

        [HttpPut("update")]
        public IActionResult UpdateBlog(Blog blog,int id)
        {
            _blogManager.UpdateBlog(blog, id);
            return Ok(new { status = 200, message = blog });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteBlog(Blog blog, int id)
        {
            _blogManager.RemoveBlog(blog, id);
            return Ok("Blog deleted.");
        }
        [HttpGet("getblogbyid")]
        public object GetBlogById(int id)
        {
            return _blogManager.GetBlogById(id);
        }
    }
}
