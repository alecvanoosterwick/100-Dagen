//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Publishers_Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stores()
        {
            this.Sales = new HashSet<Sales>();
        }
    
        public string stor_id { get; set; }
        public string stor_name { get; set; }
        public string stor_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
