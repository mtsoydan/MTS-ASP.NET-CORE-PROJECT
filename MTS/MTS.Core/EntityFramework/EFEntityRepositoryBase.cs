using MTS.Core.DataAcces;
using MTS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;


using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MTS.Core.EntityFramework
{
  public  class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()

    {
        public void Add(TEntity Entity)
        {
            //Idisposibleımızıtanımlayalım
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(Entity);
                addedEntity.State = EntityState.Added;


            }
        }
        public void Delete(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;


            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> Filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(Filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> Filter = null)
        {
            using (var context = new TContext())
            {
                return context == null ?
                     context.Set<TEntity>().ToList() :
                     context.Set<TEntity>().Where(Filter).ToList();
            }
        }

        public void Update(TEntity Entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(Entity);
                updatedEntity.State = EntityState.Modified;


            }
        }
    }
}
