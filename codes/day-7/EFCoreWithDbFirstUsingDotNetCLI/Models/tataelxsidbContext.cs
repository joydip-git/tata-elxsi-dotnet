using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreWithDbFirstUsingDotNetCLI.Models
{
    public partial class tataelxsidbContext : DbContext
    {
        public tataelxsidbContext()
        {
        }

        public tataelxsidbContext(DbContextOptions<tataelxsidbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;database=tataelxsidb;user id=sa;password=sqlserver2017;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Employeename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeename");

                entity.Property(e => e.Employeesalary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("employeesalary");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
