using ECommerce.Models;
using ECommerce.Utility.Results;
using System.Linq.Expressions;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Abstract
{
    public interface IBrandService
    {
        Task<IResult> AddAsync(Brand brand);
        Task<IResult> UpdateAsync(Brand brand);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<Brand>>> GetAllAsync();
        Task<IDataResult<Brand>> GetByIdAsync(int id);
    }
}
