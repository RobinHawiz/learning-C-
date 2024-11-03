using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface IOrderData
    {
        Task<int> CreateOrder(OrderModel order);
        Task<int> DeleteOrder(int id);
        Task<OrderModel> GetOrderById(int id);
        Task<int> UpdateOrderName(int id, string orderName);
    }
}