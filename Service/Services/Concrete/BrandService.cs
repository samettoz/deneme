using Core.Repository;
using Core.Utility.Results;
using Dto;
using DtoMapper;
using Entity;

using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class BrandService : IBrandService
    {
        IEntityRepositoryBase<Brand> _brandRepository; 
        IDtoMapper<BrandDto, Brand> _brandMapper;
        public BrandService(IEntityRepositoryBase<Brand> brandRepository, IDtoMapper<BrandDto, Brand> brandMapper)
        {
            _brandRepository = brandRepository;
            _brandMapper = brandMapper;
        }

        public async Task AddAsync(BrandDto brandDto)
        {
            var brand = _brandMapper.MapToEntity(brandDto);
            await _brandRepository.AddAsync(brand);
        }

        public async Task DeleteAsync(int id)
        {
            await _brandRepository.DeleteAsync(id);
        }

        public async Task<List<BrandDto>> GetAllAsync()
        {
            var brands = await _brandRepository.GetAllAsync();
            return brands.Select(brand => _brandMapper.MapToDto(brand)).ToList();
        }

        public async Task<BrandDto> GetByIdAsync(int id)
        {
            var brand = await _brandRepository.GetAsync(b => b.Id == id);
            return _brandMapper.MapToDto(brand);
            
        }

        public async Task UpdateAsync(BrandDto brandDto)
        {
            var brand = _brandMapper.MapToEntity(brandDto);
            await _brandRepository.UpdateAsync(brand);
        }
    }
}
