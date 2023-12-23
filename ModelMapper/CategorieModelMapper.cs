using Dto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public class CategorieModelMapper : IModelMapper<CategorieModel, CategorieDto>
    {
        public CategorieDto MapToDto(CategorieModel model)
        {
            return new CategorieDto
            {
                CategorieName = model.CategorieName,
                Id = model.Id
            };
        }

        public CategorieModel MapToModel(CategorieDto dto)
        {
            return new CategorieModel
            {
                Id = dto.Id,
                CategorieName = dto.CategorieName
            };
        }
    }
}
