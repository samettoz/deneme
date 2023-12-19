using ECommerce.Context;
using ECommerce.Models;
using ECommerce.Models.Abstract;
using ECommerce.Repository;
using ECommerce.Repository.EntityFramework;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Business;
using ECommerce.Utility.FluentValidation;
using ECommerce.Utility.Results;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IResult> AddAsync(Product product)
        {
            var result = BusinessRules.Run(await CheckIfProdutNameExist(product.ProductName));
            if (result != null)
            {
                return result;
            }
            ValidationTool.Validate(new ProductValidator(), product);

            await _productRepository.AddAsync(product);

            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Product>>> GetAllAsync()
        {

            return new SuccessDataResult<List<Product>>(await _productRepository.GetAllAsync());
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllDetailAsync()
        {
            using (ECommerceDbContext context = new ECommerceDbContext())
            {
                var result = await (from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             select new ProductDetailDto
                             {
                                 ProductId = p.Id,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategorieName
                             }).ToListAsync();
                return new SuccessDataResult<List<ProductDetailDto>>(result);
            }
        }

        public async Task<IDataResult<Product>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Product>(await _productRepository.GetAsync(p => p.Id == id));
        }

        public async Task<IResult> UpdateAsync(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);

            await _productRepository.UpdateAsync(product);
            return new SuccessResult();
        }



        private async Task<IResult> CheckIfProdutNameExist(string productName)
        {
            var products = await _productRepository.GetAllAsync(p => p.ProductName == productName);
            var result = products.Any();

            if (result) 
            {
                return new ErrorResult("aynı isimde ürün mevcut");
            }
            return new SuccessResult();

        }
    }
}
