namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TruesymptomModel : DbContext
    {
        public TruesymptomModel()
            : base("name=withusafea")
        {
        }

        public virtual DbSet<symptom> symptoms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<symptom>()
                .Property(e => e.symptom_name)
                .IsUnicode(false);
        }
    }
}
