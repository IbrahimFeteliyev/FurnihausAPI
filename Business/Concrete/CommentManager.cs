using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentManager
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(CommentDTO comment)
        {
            Comment com = new()
            {
                ProductId = comment.ProductId,
                Ratings = comment.Ratings,
                Review = comment.Review,
                UserEmail = comment.UserEmail,
                UserName = comment.UserName
            };
            _commentDal.Add(com);
        }

        public List<CommentDTO> GetAllComment()
        {
            return _commentDal.GetAllComment();
        }

        public List<Comment> GetCommentById(int productId)
        {
            return _commentDal.GetAll(x => x.ProductId == productId);
        }

        public List<Comment> GetCommentByUserId(string userEmail)
        {
            return _commentDal.GetAll(x => x.UserEmail == userEmail);
        }

        public void Remove(CommentDTO comment, int id)
        {
            var current = _commentDal.Get(x => x.Id == id);
            current.UserName = comment.UserName;
            current.UserEmail = comment.UserEmail;
            current.Review = comment.Review;
            current.Ratings = comment.Ratings;
            _commentDal.Delete(current);
        }
    }
}
