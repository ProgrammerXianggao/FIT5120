namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenderAgeSafety")]
    public partial class GenderAgeSafety
    {
        public int Id { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Assault { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Total { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Violencerate { get; set; }

        [Required]
        public string Levell { get; set; }
    }
}
