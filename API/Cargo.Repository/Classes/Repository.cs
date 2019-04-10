using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cargo.Infrastructure;
using Cargo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cargo.Repository.Classes
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly CargoContexto _context;

        public Repository(CargoContexto context)
        {
            _context = context;
        }

        public TEntity Create(TEntity entity)
        {
             _context.Set<TEntity>().Add(entity);
             _context.SaveChangesAsync();
             return entity;
        }

        // public TEntity Delete(int id)
        // {
        //     var entity = GetById(id);
        //     _context.Set<TEntity>().Remove(entity);
        //     _context.SaveChangesAsync();
        //     return entity;
        // }

        public TEntity Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        // public TEntity GetById(int id)
        // {
        //     throw new System.NotImplementedException();
        // }

        // public TEntity GetById(int id)
        // {
        //     return _context.Set<TEntity>()
        //         .AsNoTracking()
        //         .FirstOrDefault(e => e. == id);
        // }

        public TEntity Update(int id, TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}