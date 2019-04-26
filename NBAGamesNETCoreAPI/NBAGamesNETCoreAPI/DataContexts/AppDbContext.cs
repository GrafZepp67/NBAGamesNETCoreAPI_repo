﻿using Microsoft.EntityFrameworkCore;
using NBAGamesNETCoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAGamesNETCoreAPI.DataContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UpcomingGame> UpcomingGames { get; set; }
        public DbSet<LiveGame> LiveGames { get; set; }
        public DbSet<FinishedGame> FinishedGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UpcomingGame>().ToTable("UpcomingGames");
        }
    }
}