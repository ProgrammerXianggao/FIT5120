namespace withU.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HighRiskmodel : DbContext
    {
        public HighRiskmodel()
            : base("name=HighRiskmodel")
        {
        }

        public virtual DbSet<HighRisk> HighRisks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HighRisk>()
                .Property(e => e.First)
                .HasPrecision(1, 0);

            modelBuilder.Entity<HighRisk>()
                .Property(e => e.Second)
                .HasPrecision(1, 0);

            modelBuilder.Entity<HighRisk>()
                .Property(e => e.Third)
                .HasPrecision(1, 0);

            modelBuilder.Entity<HighRisk>()
                .Property(e => e.Fourth)
                .HasPrecision(1, 0);

            modelBuilder.Entity<HighRisk>()
                .Property(e => e.Fifth)
                .HasPrecision(1, 0);

            modelBuilder.Entity<HighRisk>()
                .Property(e => e.Sixth)
                .HasPrecision(1, 0);
        }
    }
}
