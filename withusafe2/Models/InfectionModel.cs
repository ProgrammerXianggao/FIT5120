namespace withusafe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InfectionModel : DbContext
    {
        public InfectionModel()
            : base("name=withusafeaa")
        {
        }

        public virtual DbSet<Disease_infection> Disease_infection { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disease_infection>()
                .Property(e => e.Disease_name)
                .IsUnicode(false);

            modelBuilder.Entity<Disease_infection>()
                .Property(e => e.Other_names)
                .IsUnicode(false);

            modelBuilder.Entity<Disease_infection>()
                .Property(e => e.Signs)
                .IsUnicode(false);

            modelBuilder.Entity<Disease_infection>()
                .Property(e => e.Medication)
                .IsUnicode(false);

            modelBuilder.Entity<Disease_infection>()
                .Property(e => e.Treatment)
                .IsUnicode(false);

            modelBuilder.Entity<Disease_infection>()
                .Property(e => e.Infectous_control)
                .IsUnicode(false);

            modelBuilder.Entity<Disease_infection>()
                .Property(e => e.Symptoms)
                .IsUnicode(false);
        }
    }
}
