using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Engrande.Web.Models
{
    public class WebResult<T>
    {
        public string Status { get; set; }

        public T SingleData { get; set; }

        public IEnumerable<T> ListData { get; set; }

        public string Message { get; set; }
    }
}