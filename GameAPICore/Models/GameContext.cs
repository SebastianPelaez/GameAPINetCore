using Microsoft.EntityFrameworkCore;

namespace GameAPICore.Models
{
    public class GameContext : DbContext
    {

        public GameContext(DbContextOptions<GameContext> options)
           : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<Games> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>().ToTable("tblGames");
        }
    }
}
