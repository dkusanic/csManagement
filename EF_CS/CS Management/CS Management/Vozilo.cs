namespace CS_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vozilo")]
    public partial class Vozilo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vozilo()
        {
            Servis = new HashSet<Servis>();
            Vlasnistvo = new HashSet<Vlasnistvo>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string VIN { get; set; }

        [Required]
        [StringLength(50)]
        public string Reg_oznaka { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Reg_do { get; set; }

        [Column(TypeName = "date")]
        public DateTime? God_proizvodnje { get; set; }

        public int ID_varijante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servis> Servis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vlasnistvo> Vlasnistvo { get; set; }
    }
}
