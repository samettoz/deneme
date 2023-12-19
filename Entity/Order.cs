

using Entity.Abstract;
using Entity.Enums;

namespace Entity
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus  OrderStatus { get; set; }
    }
}
