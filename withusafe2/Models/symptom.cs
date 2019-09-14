namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class symptom
    {
        public int Id { get; set; }

        [Required]
        public string symptom_name { get; set; }
    }
}
