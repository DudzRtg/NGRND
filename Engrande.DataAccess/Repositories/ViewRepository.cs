using Engrande.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.DataAccess.Repositories
{
    public class ViewRepository<T> : IViewRepository<T> where T : class
    {
        private IDbContext dbContext { get; set; }

        private DbSet<T> dbSet { get; set; }

        public ViewRepository(IDbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context", "DataContext should not be null.");

            dbContext = context;
            dbSet = context.Set<T>();
        }
        
        public IQueryable<T> RetrieveViews()
        {
            return dbSet.AsQueryable<T>();
        }

        public T RetrieveView(int key)
        {
            return dbSet.Find(key);
        }
    }
}
