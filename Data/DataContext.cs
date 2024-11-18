using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    //All this Class is Code for when we have an API and a Database
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
