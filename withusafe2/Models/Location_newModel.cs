namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Location_newModel : DbContext
    {
        public Location_newModel()
            : base("name=withusafeeeeee")
        {
        }

        public virtual DbSet<location_new> location_new { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<location_new>()
                .Property(e => e.Suburb)
                .IsUnicode(false);

            modelBuilder.Entity<location_new>()
                .Property(e => e.Offence_rate)
                .HasPrecision(10, 8);

            modelBuilder.Entity<location_new>()
                .Property(e => e.Risklevel)
                .HasPrecision(10, 8);

            modelBuilder.Entity<location_new>()
                .Property(e => e.Latitude)
                .HasPrecision(10, 8);

            modelBuilder.Entity<location_new>()
                .Property(e => e.Longitude)
                .HasPrecision(11, 8);

            modelBuilder.Entity<location_new>()
                .Property(e => e.Postcode)
                .IsUnicode(false);

            modelBuilder.Entity<location_new>()
                .Property(e => e.Offence_count)
                .IsUnicode(false);

            modelBuilder.Entity<location_new>()
                .Property(e => e.safe_count)
                .HasPrecision(4, 0);

            modelBuilder.Entity<location_new>()
                .Property(e => e.unsafe_count)
                .HasPrecision(4, 0);
        }
    }
}
