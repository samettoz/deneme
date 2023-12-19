

using Core.Repository;
using Core.Utility.Results;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        IEntityRepositoryBase<Customer> _customerRepository;
        public CustomerService(IEntityRepositoryBase<Customer> customerRepository)
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
