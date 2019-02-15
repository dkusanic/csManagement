namespace CS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vlasnistvo")]
    public partial class Vlasnistvo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_vlasnik { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_vozilo { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Pocetak_vlasnistva { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Kraj_vlasnistva { get; set; }

        public virtual Vlasnik Vlasnik { get; set; }

        public virtual Vozilo Vozilo { get; set; }
    }
}
