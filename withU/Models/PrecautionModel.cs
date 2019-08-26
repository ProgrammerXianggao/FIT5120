namespace withU.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PrecautionModel : DbContext
    {
        public PrecautionModel()
            : base("name=PrecautionModel")
        {
        }

        public virtual DbSet<Precaution> Precautions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Precaution>()
                .Property(e => e.First)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Second)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Third)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Fourth)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Fifth)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Sixth)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Seventh)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Eighth)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Precaution>()
                .Property(e => e.Nineth)
                .HasPrecision(1, 0);
        }
    }
}
