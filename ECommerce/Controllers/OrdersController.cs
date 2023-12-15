using ECommerce.Models;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IDataResult<List<Order>>> GetAll()
        {

            return await _orderService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<Order>> GetById(int id)
        {
            return await _orderService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(Order order)
        {
            return await _orderService.AddAsync(order);
        }

        [HttpPut]
        public async Task<IResult> Update(Order order)
        {
            return await _orderService.UpdateAsync(order);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _orderService.DeleteAsync(id);
        }
    }
}
