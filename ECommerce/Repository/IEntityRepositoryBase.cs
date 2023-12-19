using ECommerce.Models.Abstract;
using System.Linq.Expressions;

namespace ECommerce.Repository
{
    public interface IEntityRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null); 
    }
}
