using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnihausAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderManager _sliderManager;

        public SliderController(ISliderManager sliderManager)
        {
            _sliderManager = sliderManager;
        }

        [HttpGet("getall")]
        public List<Slider> GetAll()
        {
            return _sliderManager.GetAllSliders();
        }

        [HttpPost("add")]
        public object AddCategory(Slider slider)
        {
            _sliderManager.Add(slider);
            return Ok("Slider added.");
        }

        [HttpPut("update")]
        public IActionResult UpdateCategory(Slider slider)
        {
            _sliderManager.Update(slider);
            return Ok(new { status = 200, message = slider });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteCategory(Slider slider)
        {
            _sliderManager.Remove(slider);
            return Ok("Slider deleted.");
        }
    }
}
