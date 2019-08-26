namespace withU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Precaution")]
    public partial class Precaution
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? First { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Second { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Third { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fourth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fifth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sixth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Seventh { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Eighth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Nineth { get; set; }
    }
}
