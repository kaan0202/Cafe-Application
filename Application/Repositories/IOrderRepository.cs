using Domain.Entities.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IOrderRepository
    {
        Task<int> AddOrderAsync(Order order);
        Task<Order> UpdateOrderAsync(Order order);
        Task <List<Order>> AddRangeOrderAsync(List<Order> orders);
        Task<List<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
    }
}
