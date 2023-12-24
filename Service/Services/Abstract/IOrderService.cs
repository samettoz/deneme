

using Core.Utility.Results;
using Dto;
using Entity;

namespace Service.Services.Abstract
{
    public interface IOrderService
    {
        Task AddAsync(OrderDto orderDto);
        Task UpdateAsync(OrderDto orderDto);
        Task DeleteAsync(int id);
        Task<List<OrderDto>> GetAllAsync();
        Task<OrderDto> GetByIdAsync(int id);
    }
}
