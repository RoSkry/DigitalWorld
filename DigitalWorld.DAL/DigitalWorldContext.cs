using DigitalWorld.DAL.Configurations;
using DigitalWorld.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalWorld.DAL
{
    public class DigitalWorldContext : DbContext
    {
        public DbSet<PlayStation> PlayStation { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<GamePad> GamePad { get; set; }
        public DbSet<ProductSize> ProductSize { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Game> Game { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-190EJV1;Database=DigitalWorld;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<PlayStation>(new PlayStationConfiguration());
            modelBuilder.ApplyConfiguration<Card>(new CardConfiguration());
            modelBuilder.ApplyConfiguration<GamePad>(new GamePadConfiguration());
            modelBuilder.ApplyConfiguration<ProductSize>(new ProductSizeConfiguration());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<Game>(new GameConfiguration());
        }
    }
}
