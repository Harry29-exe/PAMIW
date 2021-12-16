using Microsoft.EntityFrameworkCore;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Infrastructure.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<SkiJumper> SkiJumper { get; set; }
        
        public DbSet<Trainer> Trainer { get; set; }

    }
}