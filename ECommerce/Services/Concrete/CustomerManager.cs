using ECommerce.Models;
using ECommerce.Repository;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Services.Concrete
{
    public class CustomerManager : ICustomerService
    {
        IEntityRepositoryBase<Customer> _customerRepository;
        public CustomerManager(IEntityRepositoryBase<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IResult> AddAsync(Customer customer)
        {
            _customerRepository.AddAsync(customer);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _customerRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Customer>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Customer>>(await _customerRepository.GetAllAsync());
        }

        public async Task<IDataResult<Customer>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Customer>(await _customerRepository.GetAsync(c => c.Id == id));

        }

        public async Task<IResult> UpdateAsync(Customer customer)
        {
            await _customerRepository.UpdateAsync(customer);
            return new SuccessResult();
        }
    }
}
