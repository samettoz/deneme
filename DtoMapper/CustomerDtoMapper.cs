using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public class CustomerDtoMapper : IDtoMapper<CustomerDto, Customer>
    {
        public CustomerDto MapToDto(Customer entity)
        {
            return new CustomerDto
            {
                Id = entity.Id,
                Adress = entity.Adress,
                City = entity.City,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Password = entity.Password,
                Phone = entity.Phone,
                UserName = entity.UserName,
            };
        }

        public Customer MapToEntity(CustomerDto dto)
        {
            return new Customer
            {
                Id = dto.Id,
                Adress = dto.Adress,
                City = dto.City,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Password = dto.Password,
                Phone = dto.Phone,
                UserName = dto.UserName
            };
        }
    }
}
