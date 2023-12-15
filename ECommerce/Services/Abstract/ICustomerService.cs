using ECommerce.Models;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Abstract
{
    public interface ICustomerService
    {
        Task<IResult> AddAsync(Customer customer);
        Task<IResult> UpdateAsync(Customer customer);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<Customer>>> GetAllAsync();
        Task<IDataResult<Customer>> GetByIdAsync(int id);

    }
}
