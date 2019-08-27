namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LocationModel : DbContext
    {
        public LocationModel()
            : base("name=LocationModel")
        {
        }

        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.OffenceCount)
                .HasPrecision(20, 13);

            modelBuilder.Entity<Location>()
                .Property(e => e.Population)
                .HasPrecision(20, 13);

            modelBuilder.Entity<Location>()
                .Property(e => e.Postcode)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Location>()
                .Property(e => e.OffenceRate)
                .HasPrecision(17, 16);
        }
    }
}
