using WebApiDemo3_22_10.Entities;
using WebApiDemo3_22_10.Repository.Abstract;
using WebApiDemo3_22_10.Repository.Concret;
using WebApiDemo3_22_10.Services.Abstract;

namespace WebApiDemo3_22_10.Services.Concretes
{
    public class EFProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public EFProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }
    }
}
