using ECommerce.Models;
using ECommerce.Services.Abstract;
using ECommerce.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IResult = ECommerce.Utility.Results.IResult;

namespace ECommerce.Controllers
{
    [Route("api/orderDetails")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailService _orderDetailService;
        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public async Task<IDataResult<List<OrderDetail>>> GetAll()
        {

            return await _orderDetailService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<OrderDetail>> GetById(int id)
        {
            return await _orderDetailService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(OrderDetail orderDetail)
        {
            return await _orderDetailService.AddAsync(orderDetail);
        }

        [HttpPut]
        public async Task<IResult> Update(OrderDetail orderDetail)
        {
            return await _orderDetailService.UpdateAsync(orderDetail);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _orderDetailService.DeleteAsync(id);
        }
    }
}
