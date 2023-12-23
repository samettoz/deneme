using Business.Abstract;
using Core.Utility.Results;
using Dto;
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
    public class CategorieManager : ICategorieManager
    {
        ICategorieService _categorieService;
        IModelMapper<CategorieModel, CategorieDto> _modelMapper;
        public CategorieManager(ICategorieService categorieService, IModelMapper<CategorieModel, CategorieDto> modelMapper)
        {
            _categorieService = categorieService;
            _modelMapper = modelMapper;
        }
        public async Task<IResult> AddAsync(CategorieModel categorieModel)
        {
            var categorieDto = _modelMapper.MapToDto(categorieModel);
            await _categorieService.AddAsync(categorieDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _categorieService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<CategorieModel>>> GetAllAsync()
        {
            var categorieDtos = await _categorieService.GetAllAsync();
            var categorieModels = categorieDtos.Select(categorieDto => _modelMapper.MapToModel(categorieDto)).ToList();
            return new SuccessDataResult<List<CategorieModel>>(categorieModels);
        }

        public async Task<IDataResult<CategorieModel>> GetById(int id)
        {
            var categorieDto = await _categorieService.GetByIdAsync(id);
            return new SuccessDataResult<CategorieModel>(_modelMapper.MapToModel(categorieDto));
        }

        public async Task<IResult> UpdateAsync(CategorieModel categorieModel)
        {
            var categorieDto = _modelMapper.MapToDto(categorieModel);
            await _categorieService.UpdateAsync(categorieDto);
            return new SuccessResult();
        }
    }
}
