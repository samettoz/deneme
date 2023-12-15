using ECommerce.Models;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategorieService _categorieService;
        public CategoriesController(ICategorieService categorieService)
        {
            _categorieService = categorieService;
        }

        [HttpGet]
        public async Task<IDataResult<List<Categorie>>> GetAll()
        {

            return await _categorieService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<Categorie>> GetById(int id)
        {
            return await _categorieService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(Categorie categorie)
        {
            return await _categorieService.AddAsync(categorie);
        }

        [HttpPut]
        public async Task<IResult> Update(Categorie categorie)
        {
            return await _categorieService.UpdateAsync(categorie);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _categorieService.DeleteAsync(id);
        }
    }
}
