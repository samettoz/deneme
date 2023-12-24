

using Core.Utility.Results;
using Dto;


namespace Service.Services.Abstract
{
    public interface ICategorieService
    {
        Task AddAsync(CategorieDto categorieDto);
        Task UpdateAsync(CategorieDto categorieDto);
        Task DeleteAsync(int id);
        Task<CategorieDto> GetByIdAsync(int id);
        Task<List<CategorieDto>> GetAllAsync();
    }
}
