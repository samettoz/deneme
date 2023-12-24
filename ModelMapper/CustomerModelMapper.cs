using Dto;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public class CustomerModelMapper : IModelMapper<CustomerModel, CustomerDto>
    {
        public CustomerDto MapToDto(CustomerModel model)
        {
            return new CustomerDto
            {
                Adress = model.Adress,
                City = model.City,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Id = model.Id,
                Password = model.Password,
                Phone = model.Phone,
                UserName = model.UserName
            }; 
        }

        public CustomerModel MapToModel(CustomerDto dto)
        {
            return new CustomerModel
            {
                UserName = dto.UserName,
                Phone = dto.Phone,
                Password = dto.Password,
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Adress = dto.Adress,
                City = dto.City
            };
        }
    }
}
