using HotelSerivce.Data.Abstract;
using HotelService.Entity.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfGenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;

        public EfGenericRepository(DbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {

            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();

        }

        public void Delete(TEntity entity)
        {

            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();

        }
        public IQueryable<TEntity> GetAllInclude(Expression<Func<TEntity, bool>> filter = null, params string[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
                
            }
            return query;

        }
        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {

            return _context.Set<TEntity>().SingleOrDefault(filter);

        }

        public void Update(TEntity entity)
        {

            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();

        }
      
        /*  public void SaveChanges()
          {
              _context.SaveChanges();
          }*/

    }
}
