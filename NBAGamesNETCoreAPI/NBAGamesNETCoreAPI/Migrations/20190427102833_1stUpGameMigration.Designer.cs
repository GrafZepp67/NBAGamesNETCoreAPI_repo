﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NBAGamesNETCoreAPI.DataContexts;

namespace NBAGamesNETCoreAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190427102833_1stUpGameMigration")]
    partial class _1stUpGameMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NBAGamesNETCoreAPI.Models.UpcomingGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameId");

                    b.Property<DateTime>("GameStartDateTimeUTC");

                    b.Property<string>("LastUpdated");

                    b.Property<string>("TeamAFullName");

                    b.Property<string>("TeamALogoSrc");

                    b.Property<string>("TeamATriCode");

                    b.Property<string>("TeamBFullName");

                    b.Property<string>("TeamBLogoSrc");

                    b.Property<string>("TeamBTriCode");

                    b.HasKey("Id");

                    b.ToTable("UpcomingGames");
                });
#pragma warning restore 612, 618
        }
    }
}
