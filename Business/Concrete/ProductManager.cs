
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

        public async Task<IDataResult<List<ProductModel>>> GetAllAsync()
        {
            var productDtos = await _productService.GetAllAsync();
            var productModels = productDtos.Data.Select(pd => _modelMapper.MapToModel(pd)).ToList();
            return new SuccessDataResult<List<ProductModel>>(productModels);
        }

        public async Task<IDataResult<ProductModel>> GetByIdAsync(int id)
        {
            var productDto = await _productService.GetByIdAsync(id);
            var productModel = _modelMapper.MapToModel(productDto.Data);
            return new SuccessDataResult<ProductModel>(productModel);
        }

        public async Task<IResult> UpdateAsync(ProductModel productModel)
        {
            var productDto = _modelMapper.MapToDto(productModel);
            return await _productService.UpdateAsync(productDto);

        }
    }
}
