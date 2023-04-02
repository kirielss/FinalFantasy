using Microsoft.EntityFrameworkCore;
using FinalFantasy.Models;

namespace FinalFantasy
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

