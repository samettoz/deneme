
using Dto;
using Entity;
using Core.Utility.Results;

namespace Service.Services.Abstract
{
    public interface IProductService 
    {
        Task<IResult> AddAsync(ProductDto productDto);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> UpdateAsync(ProductDto productDto);
        Task<IDataResult<ProductDto>> GetByIdAsync(int id);
        Task<IDataResult<List<ProductDto>>> GetAllAsync();
        
       
    }
}
