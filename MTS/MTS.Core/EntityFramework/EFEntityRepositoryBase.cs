using MTS.Core.DataAcces;
using MTS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MTS.Core.EntityFramework
{
    class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()

    {
        public void Add(TEntity Entity)
        {
            //Idisposibleımızıtanımlayalım

           
        }

        public void Delete(TEntity Entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> Filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TContext>().SingleOrDefaultAsync(Filter);
            }
        }

        public TEntity GetList(Expression<Func<TEntity, bool>> Filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
