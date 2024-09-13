using Microsoft.EntityFrameworkCore;
using WebApiDemo3_22_10.Data;
using WebApiDemo3_22_10.Entities;
using WebApiDemo3_22_10.Repository.Abstract;

namespace WebApiDemo3_22_10.Repository.Concret
{
    public class EFOrderRepository : IOrderRepository
    {
        private readonly ShoppingDbContext _shoppingDbContext;

        public EFOrderRepository(ShoppingDbContext shoppingDbContext)
        {
            _shoppingDbContext = shoppingDbContext;
        }

        public async Task AddAsync(Order order)
        {
            await _shoppingDbContext.AddAsync(order);
            await _shoppingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var temp=await _shoppingDbContext.Orders.FirstOrDefaultAsync(o => o.Id==id);
            if (temp != null)
            {
                _shoppingDbContext.Remove(temp);
                await _shoppingDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Order>> GetAllAsync()
        {
           return await _shoppingDbContext.Orders.ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            var temp=await _shoppingDbContext.Orders.FirstOrDefaultAsync(o=>o.Id==id);
            return temp!;
        }

        public async Task UpdateAsync(Order order)
        {
           _shoppingDbContext.Orders.Update(order);
            await _shoppingDbContext.SaveChangesAsync();
        }
    }
}
