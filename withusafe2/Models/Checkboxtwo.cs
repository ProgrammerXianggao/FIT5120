namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Checkboxtwo")]
    public partial class Checkboxtwo
    {
        public int Id { get; set; }

        public string content { get; set; }
    }
}
