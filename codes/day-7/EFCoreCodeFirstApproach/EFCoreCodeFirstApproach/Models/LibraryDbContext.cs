using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstApproach.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;database=librarydb;user id=sa;password=sqlserver2017");
        }
        public DbSet<Book> Books { set; get; }
        public DbSet<Member> Members { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>()
        //        .Property(b => b.Name)
        //        .HasColumnName("bookname")
        //        .HasColumnType("varchar")
        //        .HasMaxLength(50)
        //        .IsRequired();

        //    modelBuilder.Entity<Book>()
        //         .Property(b => b.Id)
        //         .HasColumnName("bookid")
        //         .HasColumnType("int");
                 
        //}
    }
}
