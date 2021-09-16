using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ekitap.data.Abstract;

namespace ekitap.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity,TContext> : IRepository<TEntity>
        where TEntity:class
        where TContext:DbContext,new()
    {
        public void Create(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        //bütün kitaplarıl listeler:
        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {   

                return context.Set<TEntity>().ToList();
            }
        }


        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        
    }
}