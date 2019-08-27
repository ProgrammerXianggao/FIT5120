namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PatienLocationId")]
    public partial class PatienLocationId
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PLI { get; set; }
    }
}
