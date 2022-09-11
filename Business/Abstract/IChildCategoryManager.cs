using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IChildCategoryManager
    {
        void Add(ChildCategory childCategory);
        void Remove(ChildCategory childCategory);
        void Update(ChildCategory childCategory);
        List<ChildCategory> GetAllChildCategories();
        ChildCategory GetChildCategoryById(int id);
    }
}
