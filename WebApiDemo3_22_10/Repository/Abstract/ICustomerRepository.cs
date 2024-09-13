using WebApiDemo3_22_10.Entities;

namespace WebApiDemo3_22_10.Repository.Abstract
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<Customer> GetByIdAsync(int id);
        Task UpdateAsync(Customer customer);
        Task AddAsync(Customer customer);
    }
}
