

using Core.Utility.Results;
using Dto;
using Entity;

namespace Service.Services.Abstract
{
    public interface ICustomerService
    {
        Task AddAsync(CustomerDto customerDto);
        Task UpdateAsync(CustomerDto customerDto);
        Task DeleteAsync(int id);
        Task<List<CustomerDto>> GetAllAsync();
        Task<CustomerDto> GetByIdAsync(int id);

    }
}
