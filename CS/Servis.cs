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
    
    public partial class Servis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servis()
        {
            this.Stavka_servisa = new HashSet<Stavka_servisa>();
        }
    
        public int ID { get; set; }
        public System.DateTime Datum_vrijeme { get; set; }
        public string Opis { get; set; }
        public int ID_serviser { get; set; }
        public int ID_vozilo { get; set; }
    
        public virtual Serviser Serviser { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_servisa> Stavka_servisa { get; set; }
    }
}
