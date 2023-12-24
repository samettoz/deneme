using IResult = Core.Utility.Results.IResult;
using Business.Abstract;
using Core.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailBusiness _orderDetailBusiness;
        public OrderDetailsController(IOrderDetailBusiness orderDetailBusiness)
        {
            _orderDetailBusiness = orderDetailBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<OrderDetailModel>>> GetAll()
        {
            return await _orderDetailBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<OrderDetailModel>> GetById([FromRoute] int id)
        {
            return await _orderDetailBusiness.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(OrderDetailModel orderDetailModel)
        {
            return await _orderDetailBusiness.AddAsync(orderDetailModel);
        }

        [HttpPut]
        public async Task<IResult> Update(OrderDetailModel orderDetailModel)
        {
            return await _orderDetailBusiness.UpdateAsync(orderDetailModel);
        }

        [HttpDelete("{id}")]
        public Task<IResult> Delete(int id)
        {
            return _orderDetailBusiness.DeleteAsync(id);
        }

    }
}
