using ECommerce.Models;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Abstract
{
    public interface IProductService 
    {
        IResult Add(Product product);
        IResult Delete(int id);
        IResult Update(Product product);
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetAllDetail();
       
    }
}
