

using Core.Repository;
using Core.Utility.Results;
using Dto;
using DtoMapper;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class OrderService : IOrderService
    {
        IEntityRepositoryBase<Order> _orderRepository;
        IDtoMapper<OrderDto, Order> _dtoMapper;
        public OrderService(IEntityRepositoryBase<Order> orderRepository, IDtoMapper<OrderDto, Order> dtoMapper)
        {
            _orderRepository = orderRepository;
            _dtoMapper = dtoMapper;
        }

        public async Task AddAsync(OrderDto orderDto)
        {
            var order = _dtoMapper.MapToEntity(orderDto);
            await _orderRepository.AddAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }

        public async Task<List<OrderDto>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            return orders.Select(order => _dtoMapper.MapToDto(order)).ToList();
        }

        public async Task<OrderDto> GetByIdAsync(int id)
        {
            var order = await _orderRepository.GetAsync(o => o.Id == id);
            return _dtoMapper.MapToDto(order);
        }

        public async Task UpdateAsync(OrderDto orderDto)
        {
            var order = _dtoMapper.MapToEntity(orderDto);
            await _orderRepository.UpdateAsync(order);
        }
    }
}
