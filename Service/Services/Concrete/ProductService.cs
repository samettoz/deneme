using Dto;
using Entity;
using Service.Services.Abstract;
using DtoMapper;
using Core.Utility.Results;
using Core.Repository;

namespace Service.Services.Concrete
{
    public class ProductService : IProductService
    {
        IEntityRepositoryBase<Product> _productRepository;
        IDtoMapper<ProductDto, Product> _dtoMapper;
        
        public ProductService(IEntityRepositoryBase<Product> productRepository, IDtoMapper<ProductDto, Product> dtoMapper)
        {
            _productRepository = productRepository;
            _dtoMapper = dtoMapper;
        }

        public async Task AddAsync(ProductDto productDto)
        {
            var entity = _dtoMapper.MapToEntity(productDto);
            await _productRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
           await _productRepository.DeleteAsync(id);
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(product => _dtoMapper.MapToDto(product)).ToList();

        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetAsync(p => p.Id == id);
            return _dtoMapper.MapToDto(product); 
        }

        public async Task UpdateAsync(ProductDto productDto)
        {
            var updatedEntity = _dtoMapper.MapToEntity(productDto);
            await _productRepository.UpdateAsync(updatedEntity);
        }
    }
}
