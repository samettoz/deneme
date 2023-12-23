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
        IBrandManager _brandManager;
        public BrandsController(IBrandManager brandManager)
        {
            _brandManager = brandManager;
        }

        [HttpGet]
        public async Task<IDataResult<List<BrandModel>>> GetAll()
        {
            return await _brandManager.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<BrandModel>> GetById(int id) 
        {
            return await _brandManager.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(BrandModel brandModel)
        {
            return await _brandManager.AddAsync(brandModel);
        }

        [HttpPut]
        public async Task<IResult> Update(BrandModel brandModel) 
        {
            return await _brandManager.UpdateAsync(brandModel);
        }
        
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _brandManager.DeleteAsync(id);
        }


    }
}
