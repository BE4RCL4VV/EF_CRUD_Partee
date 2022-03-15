using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EF_CRUD.Models;

namespace EF_CRUD.Context
{
    public partial class SalesContext : DbContext
    {

        public static IConfiguration Configuration;
        public SalesContext()
        {
        }

        public SalesContext(DbContextOptions<SalesContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("conn"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Company1)
                    .HasMaxLength(40)
                    .HasColumnName("Company");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.Country).HasMaxLength(40);

                entity.Property(e => e.FirstName).HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(40);

                entity.Property(e => e.Phone).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
