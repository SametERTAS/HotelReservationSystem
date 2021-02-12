using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HotelSerivce.Data.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        TEntity GetById(Expression<Func<TEntity, bool>> filter = null);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        IQueryable<TEntity> GetAllInclude(Expression<Func<TEntity, bool>> filter = null, params string[] includeProperties);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
      
        // void SaveChanges();
    }
}
