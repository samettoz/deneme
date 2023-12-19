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

        public async Task<IResult> AddAsync(ProductDto productDto)
        {
            var entity = _dtoMapper.MapToEntity(productDto);
            await _productRepository.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
           await _productRepository.DeleteAsync(id);
            return new SuccessResult(); 
        }

        public async Task<IDataResult<List<Product>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Product>>(await _productRepository.GetAllAsync());
        }

        public async Task<IDataResult<Product>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Product>(await _productRepository.GetAsync(p => p.Id == id));
        }

        public async Task<IResult> UpdateAsync(ProductDto productDto)
        {
            var updatedEntity = _dtoMapper.MapToEntity(productDto);
            await _productRepository.UpdateAsync(updatedEntity);

            return new SuccessResult();
        }
    }
}
