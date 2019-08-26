namespace withU.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GenderAgeSafetyModel : DbContext
    {
        public GenderAgeSafetyModel()
            : base("name=GenderAgeSafetyModel")
        {
        }

        public virtual DbSet<GenderAgeSafety> GenderAgeSafeties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenderAgeSafety>()
                .Property(e => e.Age)
                .IsUnicode(false);

            modelBuilder.Entity<GenderAgeSafety>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<GenderAgeSafety>()
                .Property(e => e.Assault)
                .HasPrecision(10, 3);

            modelBuilder.Entity<GenderAgeSafety>()
                .Property(e => e.Total)
                .HasPrecision(10, 3);

            modelBuilder.Entity<GenderAgeSafety>()
                .Property(e => e.Violencerate)
                .HasPrecision(10, 3);

            modelBuilder.Entity<GenderAgeSafety>()
                .Property(e => e.Levell)
                .IsUnicode(false);
        }
    }
}
