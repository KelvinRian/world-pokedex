using Microsoft.EntityFrameworkCore;
using WorldPokedex.Domain.Entities;

namespace WorldPokedex.Infrastructure.Context
{
    public class WorldPokedexContext : DbContext
    {
        public DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ECM1149;Database=WorldPokedexDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
