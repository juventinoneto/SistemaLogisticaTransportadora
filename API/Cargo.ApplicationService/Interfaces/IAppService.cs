using System.Linq;

namespace Cargo.ApplicationService.Interfaces
{
    public interface IAppService<TEntity> where TEntity : class
    {
         IQueryable<TEntity> GetAll();

        // TEntity GetById(int id);

        TEntity Create(TEntity entity);

        TEntity Update(int id, TEntity entity);

        // TEntity Delete(int id);

        TEntity Delete(TEntity entity);
    }
}