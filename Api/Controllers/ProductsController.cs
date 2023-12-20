using IResult = Core.Utility.Results.IResult;
using Business.Abstract;
using Core.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductManager _productManager;
        public ProductsController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet]
        public async Task<IDataResult<List<ProductModel>>> GetAll()
        {
            return await _productManager.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<ProductModel>> GetById(int id)
        {
            return await _productManager.GetByIdAsync(id);
        }



        [HttpPost]
        public async Task<IResult> Add(ProductModel productModel)
        {
            return await _productManager.AddAsync(productModel);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _productManager.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<IResult> Update(ProductModel productModel)
        {
            return await _productManager.UpdateAsync(productModel);
        }
    }
}
