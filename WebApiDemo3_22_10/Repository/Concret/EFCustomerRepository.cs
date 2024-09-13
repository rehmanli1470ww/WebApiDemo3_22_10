using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDemo3_22_10.Data;
using WebApiDemo3_22_10.Entities;
using WebApiDemo3_22_10.Repository.Abstract;

namespace WebApiDemo3_22_10.Repository.Concret
{
    public class EFCustomerRepository : ICustomerRepository
    {
        public readonly ShoppingDbContext _shoppingDbContext;

        public EFCustomerRepository(ShoppingDbContext shoppingDbContext)
        {
            _shoppingDbContext = shoppingDbContext;
        }

        public async Task AddAsync(Customer customer)
        {
            await _shoppingDbContext.AddAsync(customer);
            await _shoppingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var temp=_shoppingDbContext.Customers.FirstOrDefault(x=>x.Id == id);
            if (temp != null) 
            {
                _shoppingDbContext.Remove(temp);
                await _shoppingDbContext.SaveChangesAsync();
            } 
            
        }

        public async Task<List<Customer>> GetAllAsync()
        {
           return await _shoppingDbContext.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var temp= await _shoppingDbContext.Customers.FirstOrDefaultAsync(x=>x.Id == id);
            return temp;
            
        }

        public async Task UpdateAsync(Customer customer)
        {
            _shoppingDbContext.Update(customer);
            await _shoppingDbContext.SaveChangesAsync();
        }
    }
}
