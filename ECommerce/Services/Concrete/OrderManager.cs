using ECommerce.Models;
using ECommerce.Repository;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Concrete
{
    public class OrderManager : IOrderService
    {
        IEntityRepositoryBase<Order> _orderRepository;
        public OrderManager(IEntityRepositoryBase<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IResult> AddAsync(Order order)
        {
            await _orderRepository.AddAsync(order);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Order>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Order>>(await _orderRepository.GetAllAsync());
        }

        public async Task<IDataResult<Order>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Order>(await _orderRepository.GetAsync(o => o.Id == id));
        }

        public async Task<IResult> UpdateAsync(Order order)
        {
            await _orderRepository.UpdateAsync(order);
            return new SuccessResult();
        }
    }
}
