using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public class OrderDtoMapper : IDtoMapper<OrderDto, Order>
    {
        public OrderDto MapToDto(Order entity)
        {
            return new OrderDto
            {
                Id = entity.Id,
                CustomerId = entity.CustomerId,
                OrderDate = entity.OrderDate,
                OrderStatus = entity.OrderStatus
            };
        }

        public Order MapToEntity(OrderDto dto)
        {
            return new Order
            {
                OrderStatus = dto.OrderStatus,
                OrderDate = dto.OrderDate,
                CustomerId = dto.CustomerId,
                Id = dto.Id
            };
        }
    }
}
