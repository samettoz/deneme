using Dto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public class OrderModelMapper : IModelMapper<OrderModel, OrderDto>
    {
        public OrderDto MapToDto(OrderModel model)
        {
            return new OrderDto
            {
                Id = model.Id,
                CustomerId = model.CustomerId,
                OrderDate = model.OrderDate,
                OrderStatus = model.OrderStatus
            };
        }

        public OrderModel MapToModel(OrderDto dto)
        {
            return new OrderModel
            {
                Id = dto.Id,
                OrderStatus = dto.OrderStatus,
                OrderDate = dto.OrderDate,
                CustomerId = dto.CustomerId,
            };
        }
    }
}
