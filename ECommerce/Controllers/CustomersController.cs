using ECommerce.Models;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.Extensibility;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IDataResult<List<Customer>>> GetAll()
        {

            return await _customerService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<Customer>> GetById(int id)
        {
            return await _customerService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(Customer customer)
        {
            return await _customerService.AddAsync(customer);
        }

        [HttpPut]
        public async Task<IResult> Update(Customer customer)
        {
            return await _customerService.UpdateAsync(customer);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _customerService.DeleteAsync(id);
        }
    }
}
