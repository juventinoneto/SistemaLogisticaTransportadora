using System.Linq;
using Cargo.ApplicationService.Interfaces;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces;

namespace Cargo.ApplicationService.Classe
{
    public class AppService<TEntity> : IAppService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public AppService(IRepository<TEntity> repository) 
        {
            _repository = repository;            
        }

        public TEntity Create(TEntity entity)
        {
            _repository.Create(entity);
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity Update(int id, TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}