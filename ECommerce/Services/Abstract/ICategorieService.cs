using ECommerce.Models;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Abstract
{
    public interface ICategorieService
    {
        Task<IResult> AddAsync(Categorie categorie);
        Task<IResult> UpdateAsync(Categorie categorie);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<Categorie>> GetByIdAsync(int id);
        Task<IDataResult<List<Categorie>>> GetAllAsync();
    }
}
