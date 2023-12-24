using Core.Utility.Results;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerBusiness
    {
        Task<IResult> AddAsync(CustomerModel customerModel);
        Task<IResult> UpdateAsync(CustomerModel customerModel);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<CustomerModel>>> GetAllAsync();
        Task<IDataResult<CustomerModel>> GetByIdAsync(int id);
    }
}
