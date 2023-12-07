using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/orderDetails")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add(OrderDetail orderDetail)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(OrderDetail orderDetail)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
