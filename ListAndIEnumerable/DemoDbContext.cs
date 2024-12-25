using Microsoft.EntityFrameworkCore;


namespace ListAndIEnumerable
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DemoBookAPI;User Id=sa;Password=123456;Encrypt=True;TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
