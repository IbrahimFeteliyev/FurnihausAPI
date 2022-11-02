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

        [HttpPut("update/{id}")]
        public IActionResult UpdateCategory(Slider slider, int id)
        {
            _sliderManager.Update(slider, id);
            return Ok(new { status = 200, message = slider });
        }

        [HttpDelete("remove/{id}")]
        public IActionResult DeleteCategory(Slider slider, int id)
        {
            _sliderManager.Remove(slider, id);
            return Ok("Slider deleted.");
        }
    }
}
