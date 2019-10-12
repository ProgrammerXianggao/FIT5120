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
        [Required]
        public string Postcode { get; set; }
        [Required]
        public string Offence_count { get; set; }
        [Required]
        public decimal? safe_count { get; set; }
        [Required]
        public decimal? unsafe_count { get; set; }
    }
}
