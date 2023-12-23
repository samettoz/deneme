using Core.Utility.Results;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderManager
    {
        Task<IResult> AddAsync(OrderModel orderModel);
        Task<IResult> UpdateAsync(OrderModel orderModel);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<OrderModel>>> GetAllAsync();
        Task<IDataResult<OrderModel>> GetByIdAsync(int id);
    }
}
