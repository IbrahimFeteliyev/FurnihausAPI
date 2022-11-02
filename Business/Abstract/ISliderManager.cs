using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISliderManager
    {
        void Add(Slider slider);
        void Remove(Slider slider, int id);
        void Update(Slider slider, int id);
        List<Slider> GetAllSliders();
    }
}
