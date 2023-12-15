using ECommerce.Models;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Controllers
{
    [Route("api/brands")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<IDataResult<List<Brand>>> GetAll()
        {
            return await _brandService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<Brand>> GetById(int id)
        {
            return await _brandService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(Brand brand)
        {
            return await _brandService.AddAsync(brand);
        }

        [HttpPut]
        public async Task<IResult> Update(Brand brand)
        {
            return await _brandService.UpdateAsync(brand);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _brandService.DeleteAsync(id);
        }
    }
}
