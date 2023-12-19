

using Core.Utility.Results;
using Entity;

namespace Service.Services.Abstract
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
