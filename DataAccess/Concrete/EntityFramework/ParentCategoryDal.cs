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
    public class ParentCategoryDal : EfEntityRepositoryBase<ParentCategory, FurnihausDbContext>, IParentCategoryDal
    {
        public List<ParentCategory> GetParentCategories(int categoryId)
        {
            using FurnihausDbContext context = new();
            var parentCategory = context.ParentCategories.Include(x => x.Category).Where(x => x.CategoryId == categoryId).ToList();
            List<ParentCategory> parentcategoryList = new();
            for (int i = 0; i < parentCategory.Count; i++)
            {
                ParentCategory categoryparent = new()
                {
                    Id = parentCategory[i].Id,
                    Name = parentCategory[i].Name,
                    Category = parentCategory[i].Category,
                    CategoryId = parentCategory[i].CategoryId
                };
                parentcategoryList.Add(categoryparent);
            }
            return parentcategoryList;
        }
    }
}
