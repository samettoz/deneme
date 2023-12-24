using Business.Abstract;
using IResult = Core.Utility.Results.IResult;
using Core.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerBusiness _customerBusiness;
        public CustomersController(ICustomerBusiness customerBusiness)
        {
            _customerBusiness = customerBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<CustomerModel>>> GetAll()
        {
            return await _customerBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<CustomerModel>> GetById(int id)
        {
            return await _customerBusiness.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(CustomerModel customerModel)
        {
            return await _customerBusiness.AddAsync(customerModel);
        }

        [HttpPut]
        public async Task<IResult> Update(CustomerModel customerModel)
        {
            return await _customerBusiness.UpdateAsync(customerModel);
        }

        [HttpDelete]
        public async Task<IResult> Delete(int id)
        {
            return await _customerBusiness.DeleteAsync(id);
        }

    }
}
