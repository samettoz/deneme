using ECommerce.Context;
using ECommerce.Models;
using ECommerce.Models.Abstract;
using ECommerce.Repository;
using ECommerce.Repository.EntityFramework;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;


namespace ECommerce.Services.Concrete
{
    public class ProductManager : IProductService
    {
        IEntityRepositoryBase<Product> _productRepository;
        public ProductManager(IEntityRepositoryBase<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IResult Add(Product product)
        {
            _productRepository.Add(product);

            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            _productRepository.Delete(id);
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAll()
        {

            return new SuccessDataResult<List<Product>>(_productRepository.GetAll());
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productRepository.Get(p => p.Id == id));
        }

        public IResult Update(Product product)
        {
            _productRepository.Update(product);
            return new SuccessResult();
        }
    }
}
