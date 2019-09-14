namespace withusafe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Disease_infection
    {
        public int Id { get; set; }

        [Required]
        public string Disease_name { get; set; }

        [Required]
        public string Other_names { get; set; }

        [Required]
        public string Signs { get; set; }

        [Required]
        public string Medication { get; set; }

        [Required]
        public string Treatment { get; set; }

        [Required]
        public string Infectous_control { get; set; }

        public int Rate { get; set; }

        [Required]
        public string Symptoms { get; set; }
    }
}
