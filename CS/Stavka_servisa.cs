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
    
    public partial class Stavka_servisa
    {
        public int ID { get; set; }
        public int ID_servis { get; set; }
        public Nullable<int> ID_dio { get; set; }
        public Nullable<int> ID_usluga { get; set; }
        public double Kolicina { get; set; }
    
        public virtual Dijelovi Dijelovi { get; set; }
        public virtual Servis Servis { get; set; }
        public virtual Usluge Usluge { get; set; }
    }
}
