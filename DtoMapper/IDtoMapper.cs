using Dto;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public interface IDtoMapper<TDto,TEntity> where TEntity : class, IEntity, new()
        where TDto : class, IDto, new()
    {
        TDto MapToDto(TEntity entity);
        TEntity MapToEntity(TDto dto);
    }
}
