﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Engrande.Web.Models.JqueryDT
{
    public class DTColumn
    {
        public string data { get; set; }

        public string name { get; set; }

        public bool searchable { get; set; }

        public bool orderable { get; set; }

        public DTSearch search { get; set; }
    }
}