using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFQuries
{
    public class DemoBookAPIDbContext : DbContext
    {
        //public DemoBookAPIDbContext():base("DemoBookAPIConnectionString")
        //{

        //}
        public DemoBookAPIDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DemoBookAPI;User Id=sa;Password=123456;Encrypt=True;TrustServerCertificate=True");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBooks> CategoryBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
                        .HasMany(e => e.Categories)
                        .WithMany(e => e.Books)
                        .UsingEntity<CategoryBooks>();
        }
    }
}
