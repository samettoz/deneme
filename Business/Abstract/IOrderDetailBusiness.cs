using Core.Utility.Results;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderDetailBusiness
    {
        Task<IResult> AddAsync(OrderDetailModel orderDetailModel);
        Task<IResult> UpdateAsync(OrderDetailModel orderDetailModel);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<OrderDetailModel>>> GetAllAsync();
        Task<IDataResult<OrderDetailModel>> GetByIdAsync(int id);
    }
}
