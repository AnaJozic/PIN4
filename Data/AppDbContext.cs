using Microsoft.EntityFrameworkCore;

namespace PIN4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }



    
    }
}
