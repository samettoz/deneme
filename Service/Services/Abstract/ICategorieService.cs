

using Core.Utility.Results;
using Entity;

namespace Service.Services.Abstract
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
