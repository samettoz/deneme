using ECommerce.Models;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Abstract
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
