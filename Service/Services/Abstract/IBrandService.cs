
using Core.Utility.Results;
using Dto;
using System.Linq.Expressions;


namespace Service.Services.Abstract
{
    public interface IBrandService
    {
        Task AddAsync(BrandDto brandDto);
        Task UpdateAsync(BrandDto brandDto);
        Task DeleteAsync(int id);
        Task<List<BrandDto>> GetAllAsync();
        Task<BrandDto> GetByIdAsync(int id);
    }
}
