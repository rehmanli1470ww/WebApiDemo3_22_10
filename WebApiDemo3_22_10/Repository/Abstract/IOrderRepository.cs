using WebApiDemo3_22_10.Entities;

namespace WebApiDemo3_22_10.Repository.Abstract
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task DeleteAsync(int id);
        Task<Order> GetByIdAsync(int id);
    }
}
