using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public class OrderDetailDtoMapper : IDtoMapper<OrderDetailDto, OrderDetail>
    {
        public OrderDetailDto MapToDto(OrderDetail entity)
        {
            return new OrderDetailDto
            {
                OrderId = entity.OrderId,
                Id = entity.Id,
                ProductId = entity.ProductId,
                Quantity = entity.Quantity,
                UnitPrice = entity.UnitPrice
            };
        }

        public OrderDetail MapToEntity(OrderDetailDto dto)
        {
            return new OrderDetail
            {
                OrderId = dto.OrderId,
                Id = dto.Id,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice
            };
        }
    }
}
