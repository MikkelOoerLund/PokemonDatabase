using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PokémonDomain
{
    public class PokemonDbContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonTypes> Types { get; set; }
        public DbSet<PokemonSpecie> Species { get; set; }
        public DbSet<PokemonBaseStats> BaseStats { get; set; }
        public DbSet<PokemonStatIncrementPerLevel> StatIncrementPerLevel { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Pokemon>()
        //        .HasOne(p => p.Types)
        //        .WithMany()
        //        .HasForeignKey(p => p.PokedexId);

        //    modelBuilder.Entity<Pokemon>()
        //        .HasOne(p => p.Specie)
        //        .WithMany()
        //        .HasForeignKey(p => p.PokedexId);

        //    modelBuilder.Entity<Pokemon>()
        //        .HasOne(p => p.BaseStats)
        //        .WithMany()
        //        .HasForeignKey(p => p.PokedexId);

        //    modelBuilder.Entity<Pokemon>()
        //        .HasOne(p => p.StatIncrementPerLevel)
        //        .WithMany()
        //        .HasForeignKey(p => p.PokedexId);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "DESKTOP-3NHSSF9",
                InitialCatalog = "PokemonDatabase",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };

            var connectionString = connectionStringBuilder.ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
