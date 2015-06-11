using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.Contract
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepo { get; set; }
        IEntityRepository<ErrorLog> ErrorLogRepo { get; set; }

        int SaveChanges();
    }
}
