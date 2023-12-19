

using Core.Utility.Results;
using Entity;

namespace Service.Services.Abstract
{
    public interface IOrderService
    {
        Task<IResult> AddAsync(Order order);
        Task<IResult> UpdateAsync(Order order);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<Order>>> GetAllAsync();
        Task<IDataResult<Order>> GetByIdAsync(int id);
    }
}
