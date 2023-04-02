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
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Title = "Final Fantasy" },
                new Game { Id = 2, Title = "Final Fantasy II" },
                new Game { Id = 3, Title = "Final Fantasy III" },
                new Game { Id = 4, Title = "Final Fantasy IV" },
                new Game { Id = 5, Title = "Final Fantasy V" },
                new Game { Id = 6, Title = "Final Fantasy VI" },
                new Game { Id = 7, Title = "Final Fantasy VII" },
                new Game { Id = 8, Title = "Final Fantasy VIII" },
                new Game { Id = 9, Title = "Final Fantasy IX" }
                );

            modelBuilder.Entity<Character>().HasData(
                new Character { Id = 1, Name = "Cloud Strife", GameId = 7 },
                new Character { Id = 2, Name = "Tifa Lockhart", GameId = 7 },
                new Character { Id = 3, Name = "Squall Leonhart", GameId = 8 },
                new Character { Id = 4, Name = "Rinoa Heartilly", GameId = 8 },
                new Character { Id = 5, Name = "Zidane Tribal", GameId = 9 },
                new Character { Id = 6, Name = "Garnet Til Alexandros XVII", GameId = 9 }
                );
        }

    }
}

