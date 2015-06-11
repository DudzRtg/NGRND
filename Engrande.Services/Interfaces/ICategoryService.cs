using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.Services.Interfaces
{
    public interface ICategoryService
    {
        IQueryable<Category> GetEntities();

        List<KeyValuePair<string, string>> GetCategoryIdName();

        IQueryable<CategoryView> GetCategoriesList(Nullable<int> page, Nullable<int> count);
    }
}
