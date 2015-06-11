using Engrande.Contract;
using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.DataAccess.Repositories
{
    public class CategoryRepository : EntityRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbContext context) : base(context)
        {
            //initialize base constructor
        }

        public IQueryable<T> GetCategoriesList<T>(int page, int count)
        {
            var holder = dbContext.Database.SqlQuery<T>(string.Format("SELECT * FROM [dbo].[GetCategoriesView]({0},{1})", page, count));
            return holder.AsQueryable();
        }
    }
}
