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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<PlayStation>();
        }
    }
}
