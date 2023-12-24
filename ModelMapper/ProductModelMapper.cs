using Dto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public class ProductModelMapper : IModelMapper<ProductModel, ProductDto>
    {
        public ProductDto MapToDto(ProductModel model)
        {
            return new ProductDto
            {
                BrandId = model.BrandId,
                CategoryId = model.CategoryId,
                Id = model.Id,
                ProductName = model.ProductName,
                QuantityPerUnit = model.QuantityPerUnit,
                UnitPrice = model.UnitPrice
            };
        }

        public ProductModel MapToModel(ProductDto dto)
        {
            return new ProductModel
            {
                UnitPrice = dto.UnitPrice,
                QuantityPerUnit = dto.QuantityPerUnit,
                ProductName = dto.ProductName,
                Id = dto.Id,
                CategoryId = dto.CategoryId,
                BrandId = dto.BrandId

            };
        }
    }
}
