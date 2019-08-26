namespace withU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Age")]
    public partial class Age
    {
        public int Id { get; set; }

        [Column("Age")]
        [Required]
        public string Age1 { get; set; }
    }
}
