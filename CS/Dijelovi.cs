//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dijelovi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dijelovi()
        {
            this.Stavka_servisa = new HashSet<Stavka_servisa>();
        }
    
        public int ID { get; set; }
        public string Naziv { get; set; }
        public double Jed_cijena { get; set; }
        public bool Original_dio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_servisa> Stavka_servisa { get; set; }
    }
}
