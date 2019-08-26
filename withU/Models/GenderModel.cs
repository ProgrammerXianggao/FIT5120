namespace withU.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GenderModel : DbContext
    {
        public GenderModel()
            : base("name=GenderModel1")
        {
        }

        public virtual DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>()
                .Property(e => e.gender1)
                .IsUnicode(false);
        }
    }
}
