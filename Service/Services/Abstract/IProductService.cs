
using Dto;
using Entity;
using Core.Utility.Results;

namespace Service.Services.Abstract
{
    public interface IProductService 
    {
        Task AddAsync(ProductDto productDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(ProductDto productDto);
        Task<ProductDto> GetByIdAsync(int id);
        Task<List<ProductDto>> GetAllAsync();
        
       
    }
}
