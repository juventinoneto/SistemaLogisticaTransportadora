using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cargo.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        // TEntity GetById(int id);

        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        // TEntity Delete(int id);

        TEntity Delete(TEntity entity);
    }
}