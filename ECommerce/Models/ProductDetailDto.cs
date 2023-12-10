using ECommerce.Models.Abstract;

namespace ECommerce.Models
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
    }
}
