using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class OrderDal : EfEntityRepositoryBase<Order, FurnihausDbContext>, IOrderDal
    {
        public List<OrderDTO> GetAllOrders()
        {
            using var context = new FurnihausDbContext();

            var orders = context.Orders.Include(x => x.Product).Include(x => x.User).Include(x => x.OrderTracking).ToList();

            List<OrderDTO> result = new();

            foreach (var order in orders)
            {
                OrderDTO orderDTO = new()
                {
                    Id = order.Id,
                    IsDelivered = order.IsDelivered,
                    UserId = order.UserId,
                    UserEmail = order.User.Email,
                    OrderTrackingId = order.OrderTrackingId,
                    ProductId = order.ProductId,
                    ProductName = order.Product.Name,
                    SKU = order.Product.SKU,
                    Status = order.OrderTracking.Name,
                    TotalPrice = order.TotalPrice,
                    TotalQuantity = order.TotalQuantity
                };
                result.Add(orderDTO);
            }

            return result;

        }
        public List<OrderDTO> GetUserOrders(int userId)
        {
            using var context = new FurnihausDbContext();
            var orderList = context.Orders.Include(X => X.Product).Include(x => x.User).Include(x => x.OrderTracking).Where(x => x.UserId == userId).ToList();

            List<OrderDTO> list = new();

            foreach (var order in orderList)
            {
                OrderDTO orderDTO = new()
                {
                    UserId = userId,
                    Id = order.Id,
                    ProductId = order.ProductId,
                    IsDelivered = order.IsDelivered,
                    ProductName = order.Product.Name,
                    SKU = order.Product.SKU,
                    UserEmail = order.User.Email,
                    Status = order.OrderTracking.Name,
                    TotalPrice = order.TotalPrice,
                    TotalQuantity = order.TotalQuantity,
                    OrderTrackingId = order.OrderTrackingId
                };
                list.Add(orderDTO);
            }
            return list;

        }
    }

}