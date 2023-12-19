

using Core.Repository;
using Core.Utility.Results;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class OrderService : IOrderService
    {
        IEntityRepositoryBase<Order> _orderRepository;
        public OrderService(IEntityRepositoryBase<Order> orderRepository)
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
