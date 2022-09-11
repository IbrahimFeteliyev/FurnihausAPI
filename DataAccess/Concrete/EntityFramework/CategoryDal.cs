using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CategoryDal : EfEntityRepositoryBase<Category, FurnihausDbContext>, ICategoryDal
    {
        public List<Category> GetAllCat()
        {
            using (FurnihausDbContext context = new())
            {
                var categories = context.Categories.Include(x => x.ChildCategory).Take(3).ToList();

                return categories;
            }
        }
    }
}
