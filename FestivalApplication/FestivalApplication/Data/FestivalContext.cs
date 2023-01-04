using Microsoft.EntityFrameworkCore;
using FestivalApplication.Models;

namespace FestivalApplication.Data
{
    public class FestivalContext : DbContext
    {
        public FestivalContext(DbContextOptions<FestivalContext> options) : base(options)
        {

        }

        public DbSet<Artiest> Artiesten { get; set; }
        public DbSet<ArtiestDatum> ArtiestDatums { get; set; }
        public DbSet<ArtiestGenre> ArtiestGenres { get; set; }
        public DbSet<Factuur> Facturen { get; set; }
        public DbSet<FactuurProduct> FactuurProducten { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<Stage> Stages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artiest>().ToTable("Artiest");
            modelBuilder.Entity<ArtiestDatum>().ToTable("ArtiestDatum");
            modelBuilder.Entity<ArtiestGenre>().ToTable("ArtiestGenre");
            modelBuilder.Entity<Factuur>().ToTable("Factuur");
            modelBuilder.Entity<FactuurProduct>().ToTable("FactuurProduct");
            modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Stage>().ToTable("Stage");
        }
    }
}
