using ECommerce.Models.Abstract;

namespace ECommerce.Models
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
