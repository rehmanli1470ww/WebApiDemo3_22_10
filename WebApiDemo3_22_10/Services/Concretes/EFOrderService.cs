using WebApiDemo3_22_10.Entities;
using WebApiDemo3_22_10.Repository.Abstract;
using WebApiDemo3_22_10.Repository.Concret;
using WebApiDemo3_22_10.Services.Abstract;

namespace WebApiDemo3_22_10.Services.Concretes
{
    public class EFOrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public EFOrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task AddAsync(Order order)
        {
            await _orderRepository.AddAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Order order)
        {
            await _orderRepository.UpdateAsync(order);
        }
    }
}
