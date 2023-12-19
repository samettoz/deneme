using Core.Repository;
using Core.Utility.Results;
using Entity;

using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class BrandService : IBrandService
    {
        IEntityRepositoryBase<Brand> _brandRepository; 
        public BrandService(IEntityRepositoryBase<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<IResult> AddAsync(Brand brand)
        {
            await _brandRepository.AddAsync(brand);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _brandRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Brand>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Brand>>(await _brandRepository.GetAllAsync());
        }

        public async Task<IDataResult<Brand>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Brand>(await _brandRepository.GetAsync(b => b.Id == id));
        }

        public async Task<IResult> UpdateAsync(Brand brand)
        {
            await _brandRepository.UpdateAsync(brand);
            return new SuccessResult();
        }
    }
}
