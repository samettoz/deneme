
using Core.Utility.Results;
using Entity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductManager
    {
        Task<IResult> AddAsync(ProductModel productModel);
        Task<IResult> UpdateAsync(ProductModel productModel);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<Product>>> GetAllAsync();
        Task<IDataResult<Product>> GetByIdAsync(int id);
    }
}
