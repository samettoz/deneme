using Core.Utility.Results;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandManager 
    {
        Task<IResult> AddAsync(BrandModel brandModel);
        Task<IResult> UpdateAsync(BrandModel brandModel);
        Task<IDataResult<List<BrandModel>>> GetAllAsync();
        Task<IDataResult<BrandModel>> GetByIdAsync(int id);
        Task<IResult> DeleteAsync(int id);
    }
}
