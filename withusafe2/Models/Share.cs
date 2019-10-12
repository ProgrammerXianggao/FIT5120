namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Share")]
    public partial class Share
    {
        public int Id { get; set; }

        [Required]
        public string Share_records { get; set; }
    }
}
