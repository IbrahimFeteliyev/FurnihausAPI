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
    public class ChildCategoryManager : IChildCategoryManager
    {
        private readonly IChildCategoryDal _childCategoryDal;

        public ChildCategoryManager(IChildCategoryDal childCategoryDal)
        {
            _childCategoryDal = childCategoryDal;
        }

        public void Add(ChildCategory childCategory)
        {
            _childCategoryDal.Add(childCategory);
        }

        public List<ChildCategory> GetAllChildCategories()
        {
            return _childCategoryDal.GetAll();
        }

        public ChildCategory GetChildCategoryById(int id)
        {
            return _childCategoryDal.Get(x => x.Id == id);
        }

        public void Remove(ChildCategory childCategory)
        {
            _childCategoryDal.Delete(childCategory);
        }

        public void Update(ChildCategory childCategory)
        {
            _childCategoryDal.Update(childCategory);
        }
    }
}
