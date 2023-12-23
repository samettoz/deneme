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
    public class BrandsController : ControllerBase
    {
        IBrandBusiness _brandBusiness;
        public BrandsController(IBrandBusiness brandBusiness)
        {
            _brandBusiness = brandBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<BrandModel>>> GetAll()
        {
            return await _brandBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<BrandModel>> GetById(int id) 
        {
            return await _brandBusiness.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(BrandModel brandModel)
        {
            return await _brandBusiness.AddAsync(brandModel);
        }

        [HttpPut]
        public async Task<IResult> Update(BrandModel brandModel) 
        {
            return await _brandBusiness.UpdateAsync(brandModel);
        }
        
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _brandBusiness.DeleteAsync(id);
        }


    }
}
