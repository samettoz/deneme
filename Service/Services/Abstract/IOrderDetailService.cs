

using Core.Utility.Results;
using Dto;
using Entity;

namespace Service.Services.Abstract
{
    public interface IOrderDetailService
    {
        Task AddAsync(OrderDetailDto orderDetailDto);
        Task UpdateAsync(OrderDetailDto orderDetailDto);
        Task DeleteAsync(int id);
        Task<List<OrderDetailDto>> GetAllAsync();
        Task<OrderDetailDto> GetByIdAsync(int id);
    }
}
