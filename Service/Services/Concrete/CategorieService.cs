

using Core.Repository;
using Core.Utility.Results;
using Dto;
using DtoMapper;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class CategorieService : ICategorieService
    {
        IEntityRepositoryBase<Categorie> _categorieRepository;
        IDtoMapper<CategorieDto, Categorie> _dtoMapper;
        public CategorieService(IEntityRepositoryBase<Categorie> categorieRepository, IDtoMapper<CategorieDto, Categorie> dtoMapper)
        {
            _categorieRepository = categorieRepository;
            _dtoMapper = dtoMapper;
        }

        public async Task AddAsync(CategorieDto categorieDto)
        {
            var categorie = _dtoMapper.MapToEntity(categorieDto);
            await _categorieRepository.AddAsync(categorie);
            
        }

        public async Task DeleteAsync(int id)
        {
            await _categorieRepository.DeleteAsync(id);
        }

        public async Task<List<CategorieDto>> GetAllAsync()
        {
            var categories = await _categorieRepository.GetAllAsync();
            return  categories.Select(categorie => _dtoMapper.MapToDto(categorie)).ToList();
        }

        public async Task<CategorieDto> GetByIdAsync(int id)
        {
            var categorie = await _categorieRepository.GetAsync(c => c.Id == id);
            return _dtoMapper.MapToDto(categorie);
        }

        public async Task UpdateAsync(CategorieDto categorieDto)
        {
            var categorie = _dtoMapper.MapToEntity(categorieDto);
            await _categorieRepository.UpdateAsync(categorie);
        }
    }
}
