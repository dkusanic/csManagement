namespace CS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Servis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servis()
        {
            Stavka_servisa = new HashSet<Stavka_servisa>();
        }

        public int ID { get; set; }

        public DateTime Datum_vrijeme { get; set; }

        [StringLength(255)]
        public string Opis { get; set; }

        public int ID_serviser { get; set; }

        public int ID_vozilo { get; set; }

        public virtual Serviser Serviser { get; set; }

        public virtual Vozilo Vozilo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_servisa> Stavka_servisa { get; set; }
    }
}
