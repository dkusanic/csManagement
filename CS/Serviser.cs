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
    
    public partial class Serviser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Serviser()
        {
            this.Servis = new HashSet<Servis>();
        }
    
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kor_ime { get; set; }
        public string Lozinka { get; set; }
        public bool Admin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servis> Servis { get; set; }
    }
}
