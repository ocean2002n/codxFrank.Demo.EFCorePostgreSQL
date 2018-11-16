using System;
using Microsoft.EntityFrameworkCore;

namespace codxFrank.Demo.EFCorePostgreSQLCodeFirst.Models
{
    public partial class PHIS2Context : DbContext
    {
        public PHIS2Context()
        {
        }

        public PHIS2Context(DbContextOptions<PHIS2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=32769;Database=PHIS2;Username=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Name).HasMaxLength(20);
            });
        }
    }
}