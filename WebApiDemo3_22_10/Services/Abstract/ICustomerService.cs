using WebApiDemo3_22_10.Entities;

namespace WebApiDemo3_22_10.Services.Abstract
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(Customer customer);
        Task AddAsync(Customer customer);
    }
}
