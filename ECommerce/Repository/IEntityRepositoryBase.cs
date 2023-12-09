using ECommerce.Models.Abstract;
using System.Linq.Expressions;

namespace ECommerce.Repository
{
    public interface IEntityRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null); 
    }
}
