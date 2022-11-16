
using System.Linq.Expressions;

namespace Curso.ComercioElectronico.Domain;


public interface IRepository<TEntity,TEntityId> where TEntity : class
{
    IUnitOfWork UnitOfWork { get; }
    
    IQueryable<TEntity> GetAll(bool asNoTracking = true);

    //Task<TEntity> GetByIdAsync(int id);
    Task<TEntity> GetByIdAsync(TEntityId id); //genérico del id string/guid

    Task<TEntity> AddAsync(TEntity entity);

    Task UpdateAsync (TEntity entity);

    void  Delete(TEntity entity);

    IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
}
