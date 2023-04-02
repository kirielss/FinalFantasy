using Microsoft.EntityFrameworkCore;
using FinalFantasy.Models;

namespace FinalFantasy.Data
{
    public class FinalFantasyDbContext : DbContext
    {
        public FinalFantasyDbContext(DbContextOptions<FinalFantasyDbContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}

