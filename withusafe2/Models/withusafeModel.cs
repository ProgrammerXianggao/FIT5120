namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class withusafeModel : DbContext
    {
        public withusafeModel()
            : base("name=withusafee")
        {
        }

        public virtual DbSet<Age> Ages { get; set; }
        public virtual DbSet<Checkboxone> Checkboxones { get; set; }
        public virtual DbSet<Checkboxtwo> Checkboxtwoes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GenderAgeSafety> GenderAgeSafeties { get; set; }
        public virtual DbSet<HighRisk> HighRisks { get; set; }
        public virtual DbSet<Precaution> Precautions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Age>()
                .Property(e => e.Age1)
                .IsUnicode(false);

            modelBuilder.Entity<Checkboxone>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<Checkboxtwo>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.genderr)
                .IsUnicode(false);

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
