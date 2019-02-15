namespace CS_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("voziloView")]
    public partial class voziloView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string VIN { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(152)]
        public string Vozilo { get; set; }

        [Key]
        [Column("Registarska oznaka", Order = 3)]
        [StringLength(50)]
        public string Registarska_oznaka { get; set; }

        [Column("Registriran do", TypeName = "date")]
        public DateTime? Registriran_do { get; set; }

        [Column("Godina proizvodnje", TypeName = "date")]
        public DateTime? Godina_proizvodnje { get; set; }
    }
}
