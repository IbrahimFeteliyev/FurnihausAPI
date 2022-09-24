using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentManager
    {
        List<Comment> GetCommentById(int productId);
        List<Comment> GetCommentByUserId(string userEmail);
        void AddComment(CommentDTO comment);
        void Remove(CommentDTO comment, int id);
        List<CommentDTO> GetAllComment();

    }
}
