using ECommerce.Models;
using ECommerce.Services.Abstract;
using ECommerce.Utility.FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            var validator = new ProductValidator();
            var validationResult = validator.Validate(product);

            if(!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var result = _productService.Add(product);
            if(result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            return Ok();
        }
    }
}
