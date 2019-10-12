namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShareModel : DbContext
    {
        public ShareModel()
            : base("name=withusafeaaaa")
        {
        }

        public virtual DbSet<Share> Shares { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Share>()
                .Property(e => e.Share_records)
                .IsUnicode(false);
        }
    }
}
