namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PatientLocationIdModel : DbContext
    {
        public PatientLocationIdModel()
            : base("name=withusafeeeee")
        {
        }

        public virtual DbSet<PatienLocationId> PatienLocationIds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatienLocationId>()
                .Property(e => e.PLI)
                .HasPrecision(4, 0);
        }
    }
}
