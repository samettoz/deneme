using ECommerce.Models.Abstract;

namespace ECommerce.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
       
    }
}
