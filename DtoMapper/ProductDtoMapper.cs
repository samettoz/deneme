using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public class ProductDtoMapper : IDtoMapper<ProductDto,Product>
    {
        public ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                ProductName = product.ProductName,
                QuantityPerUnit = product.QuantityPerUnit,
                UnitPrice = product.UnitPrice
            };
        }
        public Product MapToEntity(ProductDto productDto)
        {
            return new Product
            {
                BrandId = productDto.BrandId,
                CategoryId = productDto.CategoryId,
                ProductName = productDto.ProductName,
                UnitPrice = productDto.UnitPrice,
                QuantityPerUnit = productDto.QuantityPerUnit,
                Id = productDto.Id
                
            };
        }
    }
}
