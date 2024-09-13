using WebApiDemo3_22_10.Entities;
using WebApiDemo3_22_10.Repository.Abstract;
using WebApiDemo3_22_10.Services.Abstract;

namespace WebApiDemo3_22_10.Services.Concretes
{
    public class EFCustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public EFCustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddAsync(Customer customer)
        {
            await _customerRepository.AddAsync(customer);
        }

        public async Task DeleteAsync(int id)
        {
            await _customerRepository.DeleteAsync(id);
        }

        public async Task<List<Customer>> GetAllAsync()
        {
           return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Customer customer)
        {
            await _customerRepository.UpdateAsync(customer);
        }
    }
}
