namespace CS_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dijelovi")]
    public partial class Dijelovi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dijelovi()
        {
            Stavka_servisa = new HashSet<Stavka_servisa>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public double Jed_cijena { get; set; }

        public bool Original_dio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_servisa> Stavka_servisa { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
