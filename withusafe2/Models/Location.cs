namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        public int Id { get; set; }

        public string Suburb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OffenceCount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Population { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Postcode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OffenceRate { get; set; }
    }
}
