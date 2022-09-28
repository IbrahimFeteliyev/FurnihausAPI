using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
        List<OrderDTO> GetUserOrders(int userId);
        List<OrderDTO> GetAllOrders();

    }
}
