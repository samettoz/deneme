
using Entity.Abstract;

namespace Entity
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
