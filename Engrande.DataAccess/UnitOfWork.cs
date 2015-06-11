using Engrande.Contract;
using Engrande.DataAccess.Repositories;
using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContext context;

        #region Entity Repositories

        public ICategoryRepository CategoryRepo { get; set; }

        public IEntityRepository<ErrorLog> ErrorLogRepo { get; set; }

        #endregion

        #region View Repositories

        //public IViewRepository<GetCategoriesView_Result> CategoryViewRepo { get; set; }

        #endregion

        public UnitOfWork(IDbContext dbContext)
        {
            context = dbContext;
            CategoryRepo = new CategoryRepository(context);
            ErrorLogRepo = new EntityRepository<ErrorLog>(context);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
