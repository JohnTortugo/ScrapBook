using Microsoft.EntityFrameworkCore;

namespace ScrapBook
{
    public class ScrapBookDBContext : DbContext
    {
        public DbSet<Scrap> Scraps { get; set; }

        public ScrapBookDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}