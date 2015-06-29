using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Engrande.Web.Models.JqueryDT
{
    public class DTRequest
    {
        public int draw { get; set; }

        public List<DTColumn> columns { get; set; }

        public List<DTOrder> order { get; set; }

        public int start { get; set; }

        public int length { get; set; }

        public DTSearch search { get; set; }
    }
}