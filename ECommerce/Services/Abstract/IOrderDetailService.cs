using ECommerce.Models;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Abstract
{
    public interface IOrderDetailService
    {
        Task<IResult> AddAsync(OrderDetail orderDetail);
        Task<IResult> UpdateAsync(OrderDetail orderDetail);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<OrderDetail>>> GetAllAsync();
        Task<IDataResult<OrderDetail>> GetByIdAsync(int id);
    }
}
