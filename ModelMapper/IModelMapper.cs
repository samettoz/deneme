using Dto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public interface IModelMapper<TModel, TDto > where TModel : class, IModel, new()
        where TDto : class, IDto, new()
    {
        TDto MapToDto(TModel model);
        TModel MapToModel(TDto dto);
    }
}
