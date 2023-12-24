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
        ICategorieBusiness _categorieBusiness;
        public CategoriesController(ICategorieBusiness categorieBusiness)
        {
            _categorieBusiness = categorieBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<CategorieModel>>> GetAll()
        {
            return await _categorieBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<CategorieModel>> GetById(int id)
        {
            return await _categorieBusiness.GetById(id);
        }

        [HttpPost]
        public async Task<IResult> AddAsync(CategorieModel categorieModel)
        {
            return await _categorieBusiness.AddAsync(categorieModel);
        }

        [HttpDelete]
        public async Task<IResult> Delete(int id)
        {
            return await _categorieBusiness.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<IResult> Update(CategorieModel categorieModel)
        {
            return await _categorieBusiness.UpdateAsync(categorieModel);
        }
    }
}
