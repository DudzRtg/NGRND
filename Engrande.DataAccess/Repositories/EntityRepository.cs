using Engrande.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.DataAccess
{
    public class EntityRepository<T> : IEntityRepository<T> where T : class
    {
        protected IDbContext dbContext { get; set; }

        protected DbSet<T> dbSet { get; set; }

        public EntityRepository(IDbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context", "DataContext should not be null.");

            dbContext = context;
            dbSet = context.Set<T>();
        }

        public IQueryable<T> RetrieveEntities()
        {
            return dbSet;
        }

        public T RetrieveEntity(int id)
        {
            return dbSet.Find(id);
        }

        public void CreateEntity(T ent)
        {
            if (ent == null)
                throw new ArgumentNullException("ent", "No entity to be added.");

            DbEntityEntry entry = dbContext.Entry<T>(ent);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                dbSet.Add(ent);
            }

        }

        public void UpdateEntity(T ent)
        {
            if (ent == null)
                throw new ArgumentNullException("ent", "No entity to be updated.");


            DbEntityEntry entry = dbContext.Entry<T>(ent);
            if (entry.State == EntityState.Detached)
            {
                dbSet.Attach(ent);
            }
            
            entry.State = EntityState.Modified;
        }

        public void DeleteEntity(int id)
        {

            T ent = RetrieveEntity(id);
            DbEntityEntry dbEntityEntry = dbContext.Entry(ent);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                dbSet.Attach(ent);
                dbSet.Remove(ent);
            }
        }
    }
}
