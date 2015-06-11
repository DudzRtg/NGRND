using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.Contract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        IQueryable<T> GetCategoriesList<T>(int page, int count);
    }
}
