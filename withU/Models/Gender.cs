namespace withU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gender")]
    public partial class Gender
    {
        public int Id { get; set; }

        [Column("gender")]
        [StringLength(10)]
        public string gender1 { get; set; }
    }
}
