namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class location_new
    {
        public int Id { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Offence_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Risklevel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Longitude { get; set; }
    }
}
