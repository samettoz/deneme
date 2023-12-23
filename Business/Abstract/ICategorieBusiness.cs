using Core.Utility.Results;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategorieBusiness
    {
        Task<IResult> AddAsync(CategorieModel categorieModel);
        Task<IResult> DeleteAsync(int id);
        Task<IResult> UpdateAsync(CategorieModel categorieModel);
        Task<IDataResult<List<CategorieModel>>> GetAllAsync();
        Task<IDataResult<CategorieModel>> GetById(int id);
    }
}
