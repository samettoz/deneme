using ECommerce.Models;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IDataResult<List<Product>>> GetAll()
        {
            return await _productService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<Product>> GetById(int id)
        {
            return await _productService.GetByIdAsync(id);
        }

        [HttpGet("productdetail")]
        public async Task<IDataResult<List<ProductDetailDto>>> GetAllDetail()
        {
            return await _productService.GetAllDetailAsync();
        }

        [HttpPost]
        public async Task<IResult> Add(Product product)
        {
            return await _productService.AddAsync(product);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _productService.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<IResult> Update(Product product)
        {
            return await _productService.UpdateAsync(product);
        }

    
    }
}
