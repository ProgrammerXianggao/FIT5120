namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExperienceModel : DbContext
    {
        public ExperienceModel()
            : base("name=withusafeaaa")
        {
        }

        public virtual DbSet<experience> experiences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<experience>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<experience>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<experience>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<experience>()
                .Property(e => e.Published)
                .IsUnicode(false);

            modelBuilder.Entity<experience>()
                .Property(e => e.Visible)
                .IsUnicode(false);
        }
    }
}
