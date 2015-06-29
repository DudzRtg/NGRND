using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Engrande.Web.Models
{
    public class WebResult<T>
    {
        public string Status { get; set; }

        public IEnumerable<T> Data { get; set; }

        public string Message { get; set; }

        public int TotalCount { get; set; }
    }
}