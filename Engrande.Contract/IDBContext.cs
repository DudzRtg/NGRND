using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Threading;

namespace Engrande.Contract
{
    public interface IDbContext
    {
        Database Database { get; }

        void Dispose();

        DbEntityEntry Entry(object entity);
       
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        bool Equals(object obj);

        int GetHashCode();

        Type GetType();
       
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
                
        int SaveChanges();
        
        Task<int> SaveChangesAsync();
       
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        
        DbSet Set(Type entityType);
        
        string ToString();
    }
}
