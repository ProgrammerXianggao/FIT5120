namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("experience")]
    public partial class experience
    {
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }

        
        [StringLength(100)]
        public string Title { get; set; }

        
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public string Published { get; set; }

        [Required]
        [StringLength(1)]
        public string Visible { get; set; }


    }
}
