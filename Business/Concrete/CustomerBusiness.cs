using Business.Abstract;
using Core.Utility.Results;
using Dto;
using Model;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerBusiness : ICustomerBusiness
    {
        ICustomerService _customerService;
        IModelMapper<CustomerModel, CustomerDto> _modelMapper;
        public CustomerBusiness(ICustomerService customerService, IModelMapper<CustomerModel, CustomerDto> modelMapper)
        {
            _customerService = customerService;
            _modelMapper = modelMapper;
        }

        public async Task<IResult> AddAsync(CustomerModel customerModel)
        {
            var customerDto = _modelMapper.MapToDto(customerModel);
            await _customerService.AddAsync(customerDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _customerService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<CustomerModel>>> GetAllAsync()
        {
            var customerDtos = await _customerService.GetAllAsync();
            var customerModels = customerDtos.Select(customerDto => _modelMapper.MapToModel(customerDto)).ToList();
            return new SuccessDataResult<List<CustomerModel>>(customerModels);
        }

        public async Task<IDataResult<CustomerModel>> GetByIdAsync(int id)
        {
            var customerDto = await _customerService.GetByIdAsync(id);
            return new SuccessDataResult<CustomerModel>(_modelMapper.MapToModel(customerDto));
        }

        public async Task<IResult> UpdateAsync(CustomerModel customerModel)
        {
            var customerDto = _modelMapper.MapToDto(customerModel);
            await _customerService.UpdateAsync(customerDto);
            return new SuccessResult();
        }
    }
}
