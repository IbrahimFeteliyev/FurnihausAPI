using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IParentCategoryManager
    {
        void Add(ParentCategory parentcategory);
        void Remove(ParentCategory parentcategory);
        void Update(ParentCategory parentcategory);
        List<ParentCategory> GetAllParentCategories();
        List<ParentCategory> GetParentCategoriesById(int categoryId);
    }
}
