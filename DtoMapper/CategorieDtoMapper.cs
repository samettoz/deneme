using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public class CategorieDtoMapper : IDtoMapper<CategorieDto, Categorie>
    {
        public CategorieDto MapToDto(Categorie entity)
        {
            return new CategorieDto
            {
                Id = entity.Id,
                CategorieName = entity.CategorieName
            };
        }

        public Categorie MapToEntity(CategorieDto dto)
        {
            return new Categorie
            {
                CategorieName = dto.CategorieName,
                Id = dto.Id
            };
        }
    }
}
