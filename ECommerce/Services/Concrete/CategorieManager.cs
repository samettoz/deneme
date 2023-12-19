using ECommerce.Models;
using ECommerce.Repository;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Concrete
{
    public class CategorieManager : ICategorieService
    {
        IEntityRepositoryBase<Categorie> _categorieRepository;
        public CategorieManager(IEntityRepositoryBase<Categorie> categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

        public async Task<IResult> AddAsync(Categorie categorie)
        {
            await _categorieRepository.AddAsync(categorie);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _categorieRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Categorie>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Categorie>>(await _categorieRepository.GetAllAsync());
        }

        public async Task<IDataResult<Categorie>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Categorie>(await _categorieRepository.GetAsync(c => c.Id == id));
        }

        public async Task<IResult> UpdateAsync(Categorie categorie)
        {
            await _categorieRepository.UpdateAsync(categorie);
            return new SuccessResult();
        }
    }
}
