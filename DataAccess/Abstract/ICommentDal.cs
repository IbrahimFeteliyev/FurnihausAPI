using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
        List<CommentDTO> GetAllComment();
    }
}
