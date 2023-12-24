using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public class BrandDtoMapper : IDtoMapper<BrandDto, Brand>
    {
        public BrandDto MapToDto(Brand entity)
        {
            return new BrandDto
            {
                BrandName = entity.BrandName,
                Id = entity.Id
            };
        }

        public Brand MapToEntity(BrandDto dto)
        {
            return new Brand
            {
                Id = dto.Id,
                BrandName = dto.BrandName
            };
        }
    }
}
