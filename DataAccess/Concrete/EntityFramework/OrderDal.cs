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

        public List<Order> GetOrder(int userId)
        {
            using FurnihausDbContext context = new();

            var order = context.Orders.Include(x => x.Product).Include(x => x.OrderTracking).Where(x => x.UserId == userId).ToList();
            List<Order> orderList = new();
            for (int i = 0; i < order.Count; i++)
            {
                Order orderuser = new()
                {
                    Id = order[i].Id,
                    ProductId = order[i].ProductId,
                    User = order[i].User,
                    UserId = order[i].UserId,
                    TotalPrice = order[i].TotalPrice,
                    TotalQuantity = order[i].TotalQuantity,
                    OrderTrackingId = order[i].OrderTrackingId
                };
                orderList.Add(orderuser);
            }
            return orderList;
        }

        public List<OrderDTO> GetUserOrders(int userId)
        {
            using var context = new FurnihausDbContext();
            var orderList = context.Orders.Include(X => X.Product).Include(x => x.OrderTracking).Where(x => x.UserId == userId).ToList();

            List<OrderDTO> list = new();

            foreach (var order in orderList)
            {
                OrderDTO orderDTO = new()
                {
                    UserId = userId,
                    Id = order.Id,
                    IsDelivered = order.IsDelivered,
                    ProductName = order.Product.Name,
                    SKU = order.Product.SKU,
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
