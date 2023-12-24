using Business.Abstract;
using IResult = Core.Utility.Results.IResult;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Core.Utility.Results;
using Microsoft.Identity.Client;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderBusiness _orderBusiness;
        public OrdersController(IOrderBusiness orderBusiness)
        {
            _orderBusiness = orderBusiness;
        }

        [HttpPost]
        public async Task<IResult> Add(OrderModel orderModel)
        {
            return await _orderBusiness.AddAsync(orderModel);
        }

        [HttpGet]
        public async Task<IDataResult<List<OrderModel>>> GetAll() 
        {
            return await _orderBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<OrderModel>> GetById(int id)
        {
            return await _orderBusiness.GetByIdAsync(id);
        }

        [HttpPut]
        public async Task<IResult> Update(OrderModel orderModel)
        {
            return await _orderBusiness.UpdateAsync(orderModel);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _orderBusiness.DeleteAsync(id);
        }
    }
}
