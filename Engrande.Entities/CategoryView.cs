using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.Entities
{
    public class CategoryView
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ParentName { get; set; }

        public string StatusName { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}
