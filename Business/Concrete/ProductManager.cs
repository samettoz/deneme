
using Business.Abstract;
using Core.Utility.Results;
using Dto;
using Entity;
using Model;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        IProductService _productService;
        IModelMapper<ProductModel, ProductDto> _modelMapper;

        public ProductManager(IProductService productService, IModelMapper<ProductModel, ProductDto> modelMapper)
        {
            _productService = productService;
            _modelMapper = modelMapper;
        }

        public async Task<IResult> AddAsync(ProductModel productModel)
        {
            var dto = _modelMapper.MapToDto(productModel);
            return await _productService.AddAsync(dto);
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            return await _productService.DeleteAsync(id);
        }

        public async Task<IDataResult<List<Product>>> GetAllAsync()
        {
            return await _productService.GetAllAsync();
        }

        public async Task<IDataResult<Product>> GetByIdAsync(int id)
        {
            return await _productService.GetByIdAsync(id);
        }

        public async Task<IResult> UpdateAsync(ProductModel productModel)
        {
            var productDto = _modelMapper.MapToDto(productModel);
            return await _productService.UpdateAsync(productDto);

        }
    }
}
