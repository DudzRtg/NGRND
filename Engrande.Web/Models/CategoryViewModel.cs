using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Engrande.Web.Models
{
    public class CategoryViewModel
    {
        public int Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ParentName { get; set; }

        public string Status { get; set; }

        public string ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
    }
}