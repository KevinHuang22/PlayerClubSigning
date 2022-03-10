using Microsoft.EntityFrameworkCore;
using PlayerClubSigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerClubSigning.Data
{
    public class PlayerClubContext : DbContext
    {
        public PlayerClubContext(DbContextOptions<PlayerClubContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasAlternateKey(t => t.Name)
                .HasName("AlternateKey_Name");
        }
    }
}
