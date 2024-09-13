using Microsoft.EntityFrameworkCore;
using WebApiDemo3_22_10.Data;
using WebApiDemo3_22_10.Entities;
using WebApiDemo3_22_10.Repository.Abstract;

namespace WebApiDemo3_22_10.Repository.Concret
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ShoppingDbContext _shoppingDbContext;

        public EFProductRepository(ShoppingDbContext shoppingDbContext)
        {
            _shoppingDbContext = shoppingDbContext;
        }

        public async Task AddAsync(Product product)
        {
            await _shoppingDbContext.AddAsync(product);
            await _shoppingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var temp=await _shoppingDbContext.Products.FirstOrDefaultAsync(p => p.Id==id);
            if (temp != null) 
            {
                _shoppingDbContext.Products.Remove(temp);
                await _shoppingDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Product>> GetAllAsync()
        {
           return await _shoppingDbContext.Products.ToListAsync();  
        }

        public async Task<Product> GetByIdAsync(int id)
        {
           var temp=await _shoppingDbContext.Products.FirstOrDefaultAsync(p=>p.Id==id);
            return temp!;
        }

        public async Task UpdateAsync(Product product)
        {
           _shoppingDbContext.Products.Update(product);
            await _shoppingDbContext.SaveChangesAsync();
        }
    }
}
