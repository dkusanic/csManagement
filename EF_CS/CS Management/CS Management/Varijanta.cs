namespace CS_Management
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Varijanta")]
    public partial class Varijanta
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Oznaka_motora { get; set; }

        public int? Mjenjač { get; set; }

        public int? Karoserija { get; set; }

        public int ID_modela { get; set; }

        public virtual Model Model { get; set; }
    }
}
