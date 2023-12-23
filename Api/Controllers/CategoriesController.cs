using Business.Abstract;
using IResult = Core.Utility.Results.IResult;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Core.Utility.Results;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategorieManager _categorieManager;
        public CategoriesController(ICategorieManager categorieManager)
        {
            _categorieManager = categorieManager;
        }

        [HttpGet]
        public async Task<IDataResult<List<CategorieModel>>> GetAll()
        {
            return await _categorieManager.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<CategorieModel>> GetById(int id)
        {
            return await _categorieManager.GetById(id);
        }

        [HttpPost]
        public async Task<IResult> AddAsync(CategorieModel categorieModel)
        {
            return await _categorieManager.AddAsync(categorieModel);
        }

        [HttpDelete]
        public async Task<IResult> Delete(int id)
        {
            return await _categorieManager.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<IResult> Update(CategorieModel categorieModel)
        {
            return await _categorieManager.UpdateAsync(categorieModel);
        }
    }
}
