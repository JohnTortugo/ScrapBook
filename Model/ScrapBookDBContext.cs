using Microsoft.EntityFrameworkCore;

namespace ScrapBook
{
    public class ScrapBookDBContext : DbContext
    {
        public DbSet<Scrap> Scraps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ScrapBook;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}