using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class BlogManager : IBlogManager
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(AddBlogDTO addBlogDTO)
        {
            Blog blog = new()
            { 
                Title = addBlogDTO.Title,
                Description = addBlogDTO.Description,
                CoverPhoto = addBlogDTO.CoverPhoto,
                Image = addBlogDTO.Image,
                PublishDate = DateTime.Now
            };

            _blogDal.Add(blog);
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetAll();
        }

        public Blog GetBlogById(int id)
        {
            return _blogDal.Get(x => x.Id == id);
        }

        public void RemoveBlog(Blog blog, int id)
        {
            var current = _blogDal.Get(x => x.Id == id);
            current.CoverPhoto = blog.CoverPhoto;
            current.Description = blog.Description;
            current.Image = blog.Image;
            current.Title = blog.Title;
            current.PublishDate = blog.PublishDate;
            _blogDal.Delete(current);
        }

        public void UpdateBlog(Blog blog, int id)
        {
            var current = _blogDal.Get(x => x.Id == id);
            current.CoverPhoto = blog.CoverPhoto;
            current.Description = blog.Description;
            current.Image = blog.Image;
            current.Title = blog.Title;
            current.PublishDate = blog.PublishDate;
            _blogDal.Update(current);
        }
    }
}
