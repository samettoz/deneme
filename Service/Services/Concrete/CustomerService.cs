

using Core.Repository;
using Core.Utility.Results;
using Dto;
using DtoMapper;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        IEntityRepositoryBase<Customer> _customerRepository;
        IDtoMapper<CustomerDto,  Customer> _dtoMapper;
        public CustomerService(IEntityRepositoryBase<Customer> customerRepository, IDtoMapper<CustomerDto, Customer> dtoMapper)
        {
            _customerRepository = customerRepository;
            _dtoMapper = dtoMapper;
        }

        public async Task AddAsync(CustomerDto customerDto)
        {
            var customer = _dtoMapper.MapToEntity(customerDto);
            _customerRepository.AddAsync(customer);
        }

        public async Task DeleteAsync(int id)
        {
            await _customerRepository.DeleteAsync(id);
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return customers.Select(customer => _dtoMapper.MapToDto(customer)).ToList();
        }

        public async Task<CustomerDto> GetByIdAsync(int id)
        {
            var customer = await _customerRepository.GetAsync(c => c.Id == id);
            return _dtoMapper.MapToDto(customer);
        }

        public async Task UpdateAsync(CustomerDto customerDto)
        {
            var customer = _dtoMapper.MapToEntity(customerDto);
            await _customerRepository.UpdateAsync(customer);
        }
    }
}
