using Microsoft.EntityFrameworkCore;
using WebApiDemo3_22_10.Entities;

namespace WebApiDemo3_22_10.Data
{
    public class ShoppingDbContext:DbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }    
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }  
    }
}
