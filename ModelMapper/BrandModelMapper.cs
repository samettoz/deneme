using Dto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public class BrandModelMapper : IModelMapper<BrandModel, BrandDto>
    {
        public BrandDto MapToDto(BrandModel model)
        {
            return new BrandDto
            {
                BrandName = model.BrandName,
                Id = model.Id
            };
        }

        public BrandModel MapToModel(BrandDto dto)
        {
            return new BrandModel
            {
                Id = dto.Id,
                BrandName = dto.BrandName,
            };
        }
    }
}
