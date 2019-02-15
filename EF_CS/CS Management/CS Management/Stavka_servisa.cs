namespace CS_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stavka servisa")]
    public partial class Stavka_servisa
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_servis { get; set; }

        public int? ID_dio { get; set; }

        public int? ID_usluga { get; set; }

        public double Kolicina { get; set; }

        public virtual Dijelovi Dijelovi { get; set; }

        public virtual Servis Servis { get; set; }

        public virtual Usluge Usluge { get; set; }
    }
}
