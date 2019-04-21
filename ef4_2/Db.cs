using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ef4_2
{
    class Db:DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Bet> Bets { get; set; }
        DbSet<Game> Games { get; set; }
        DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Team> Teams { get; set; }
       // DbSet<Color> Colors { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<Town> Towns { get; set; }
        DbSet<Country> Countries { get; set; }
        
        public Db()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-V3TJMDN5\SQLEXPRESS;Database=ef4_2;Trusted_Connection=True;");
        }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>().HasKey(t => new { t.PlayerId, t.GameId });
            modelBuilder.Entity<Team>().HasOne(s => s.PrimaryKitColor)
                                        .WithMany(x => x.PrimaryTeams)
                                        .HasForeignKey(t => t.PrimaryKitColorId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Team>().HasOne(s => s.SecondaryKitColor)
                                        .WithMany(x => x.SecondaryTeams)
                                        .HasForeignKey(t => t.SecondaryKitColorId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Game>().HasOne(s => s.AwayTeam)
                                        .WithMany(x => x.AwayGames)
                                        .HasForeignKey(t => t.AwayTeamId).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Game>().HasOne(s => s.HomeTeam)
                                      .WithMany(x => x.HomeGames)
                                      .HasForeignKey(t => t.HomeTeamId).OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
