namespace withU.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AgeModel : DbContext
    {
        public AgeModel()
            : base("name=AgeModel")
        {
        }

        public virtual DbSet<Age> Ages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Age>()
                .Property(e => e.Age1)
                .IsUnicode(false);
        }
    }
}
