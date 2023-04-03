//using Business.Abstract;
//using Entities.Concrete;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace FurnihausAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ChildCategoryController : ControllerBase
//    {
//        private readonly IChildCategoryManager _childCategoryManager;

//        public ChildCategoryController(IChildCategoryManager childCategoryManager)
//        {
//            _childCategoryManager = childCategoryManager;
//        }

//        [HttpGet("getall")]
//        public List<ChildCategory> GetAll()
//        {
//            return _childCategoryManager.GetAllChildCategories();
//        }

//        [HttpPost("add")]
//        public object AddCategory(ChildCategory childCategory)
//        {
//            _childCategoryManager.Add(childCategory);
//            return Ok("Category added.");
//        }

//        [HttpPut("update")]
//        public IActionResult UpdateCategory(ChildCategory childCategory)
//        {
//            _childCategoryManager.Update(childCategory);
//            return Ok(new { status = 200, message = childCategory });
//        }

//        [HttpDelete("remove")]
//        public IActionResult DeleteCategory(ChildCategory childCategory)
//        {
//            _childCategoryManager.Remove(childCategory);
//            return Ok("Category deleted.");
//        }
//    }
//}
