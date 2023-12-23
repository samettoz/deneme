
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
            await _productService.AddAsync(dto);
            return new SuccessResult(); 
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _productService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<ProductModel>>> GetAllAsync()
        {
            var productDtos = await _productService.GetAllAsync();
            var productModels = productDtos.Select(pd => _modelMapper.MapToModel(pd)).ToList();
            return new SuccessDataResult<List<ProductModel>>(productModels);
        }

        public async Task<IDataResult<ProductModel>> GetByIdAsync(int id)
        {
            var productDto = await _productService.GetByIdAsync(id);
            return new SuccessDataResult<ProductModel>(_modelMapper.MapToModel(productDto));
        }

        public async Task<IResult> UpdateAsync(ProductModel productModel)
        {
            var productDto = _modelMapper.MapToDto(productModel);
            await _productService.UpdateAsync(productDto);
            return new SuccessResult();
        }
    }
}
