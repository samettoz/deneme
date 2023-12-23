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
    public class BrandBusiness : IBrandBusiness
    {
        IBrandService _brandService;
        IModelMapper<BrandModel, BrandDto> _brandMaper;
        public BrandBusiness(IBrandService brandService, IModelMapper<BrandModel, BrandDto> brandMapper)
        {
            _brandMaper = brandMapper;
            _brandService = brandService;
        }

        public async Task<IResult> AddAsync(BrandModel brandModel)
        {
            var brandDto = _brandMaper.MapToDto(brandModel);
            await _brandService.AddAsync(brandDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _brandService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<BrandModel>>> GetAllAsync()
        {
            var brandDtos = await _brandService.GetAllAsync();
            var brandModel = brandDtos.Select(brand => _brandMaper.MapToModel(brand)).ToList();
            return new SuccessDataResult<List<BrandModel>>(brandModel);
        }

        public async Task<IDataResult<BrandModel>> GetByIdAsync(int id)
        {
            var brandDto = await _brandService.GetByIdAsync(id);
            return new SuccessDataResult<BrandModel>(_brandMaper.MapToModel(brandDto));
        }

        public async Task<IResult> UpdateAsync(BrandModel brandModel)
        {
            var brandDto = _brandMaper.MapToDto(brandModel);
            await _brandService.UpdateAsync(brandDto);
            return new SuccessResult();
        }
    }
}
