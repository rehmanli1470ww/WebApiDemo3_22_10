using WebApiDemo3_22_10.Entities;

namespace WebApiDemo3_22_10.Services.Abstract
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(int id);
        
        Task DeleteAsync(int id);
        Task UpdateAsync(Order order);
        Task AddAsync(Order order);
    }   
}
