using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogManager
    {
        void AddBlog(AddBlogDTO addBlogDTO);
        void RemoveBlog(Blog blog,int id);
        void UpdateBlog(Blog blog,int id);
        List<Blog> GetAllBlogs();
        Blog GetBlogById(int id);

    }
}
