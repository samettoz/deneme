
using Core.Utility.Results;
using Entity;
using System.Linq.Expressions;


namespace Service.Services.Abstract
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
