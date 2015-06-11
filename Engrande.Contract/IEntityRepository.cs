using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.Contract
{
    public interface IEntityRepository<T> where T : class
    {
        IQueryable<T> RetrieveEntities();

        T RetrieveEntity(int id);

        void CreateEntity(T entity);

        void UpdateEntity(T entity);

        void DeleteEntity(int id);
    }
}
