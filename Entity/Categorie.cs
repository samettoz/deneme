

using Entity.Abstract;

namespace Entity
{
    public class Categorie : IEntity
    {
        public int Id { get; set; }
        public string CategorieName { get; set; }
    }
}
