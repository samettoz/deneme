using ECommerce.Models;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Abstract
{
    public interface IProductService 
    {
        Task<IResult> AddAsync(Product product);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> UpdateAsync(Product product);
        Task<IDataResult<Product>> GetByIdAsync(int id);
        Task<IDataResult<List<Product>>> GetAllAsync();
        Task<IDataResult<List<ProductDetailDto>>> GetAllDetailAsync();
       
    }
}
