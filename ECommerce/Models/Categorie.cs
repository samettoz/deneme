using ECommerce.Models.Abstract;

namespace ECommerce.Models
{
    public class Categorie : IEntity
    {
        public int Id { get; set; }
        public string CategorieName { get; set; }
    }
}
