using ECommerce.Context;
using ECommerce.Models;
using ECommerce.Models.Abstract;
using ECommerce.Repository;
using ECommerce.Repository.EntityFramework;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Business;
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
            var result = BusinessRules.Run(CheckIfProdutNameExist(product.ProductName));
            if (result != null)
            {
                return result;
            }

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

        private IResult CheckIfProdutNameExist(string productName)
        {
            var result = _productRepository.GetAll(p => p.ProductName == productName).Any();

            if(result) 
            {
                return new ErrorResult("aynı isimde ürün mevcut");
            }
            return new SuccessResult();

        }
    }
}
