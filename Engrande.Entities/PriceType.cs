//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Engrande.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PriceType
    {
        public PriceType()
        {
            this.Prices = new HashSet<Price>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<Price> Prices { get; set; }
    }
}
