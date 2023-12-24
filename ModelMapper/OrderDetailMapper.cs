using Dto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public class OrderDetailMapper : IModelMapper<OrderDetailModel, OrderDetailDto>
    {
        public OrderDetailDto MapToDto(OrderDetailModel model)
        {
            return new OrderDetailDto
            {
                Id = model.Id,
                OrderId = model.OrderId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                UnitPrice = model.UnitPrice
            };
        }

        public OrderDetailModel MapToModel(OrderDetailDto dto)
        {
            return new OrderDetailModel
            {
                Id = dto.Id,
                OrderId = dto.OrderId,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice
            };
        }
    }
}
