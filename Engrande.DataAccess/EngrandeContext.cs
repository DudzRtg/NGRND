using Engrande.Contract;
using Engrande.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.DataAccess
{
    public class EngrandeContext : EngrandeEntities, IDbContext
    {
        public EngrandeContext() : base()
        {
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
