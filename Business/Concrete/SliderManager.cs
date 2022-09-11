using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SliderManager : ISliderManager
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider slider)
        {
            _sliderDal.Add(slider);
        }

        public List<Slider> GetAllSliders()
        {
            return _sliderDal.GetAll();
        }

        public void Remove(Slider slider)
        {
            _sliderDal.Delete(slider);
        }

        public void Update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
    }
}
