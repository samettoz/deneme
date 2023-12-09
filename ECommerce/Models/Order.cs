using ECommerce.Models.Abstract;
using ECommerce.Models.Enums;

namespace ECommerce.Models
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus  OrderStatus { get; set; }
    }
}
