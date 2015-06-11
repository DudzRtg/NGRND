using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.Contract
{
    public interface IViewRepository<T> where T : class
    {
        IQueryable<T> RetrieveViews();

        T RetrieveView(int key);
    }
}
