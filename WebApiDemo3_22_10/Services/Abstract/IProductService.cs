using WebApiDemo3_22_10.Entities;

namespace WebApiDemo3_22_10.Services.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(Product product);
        Task AddAsync(Product product);
    }
}
