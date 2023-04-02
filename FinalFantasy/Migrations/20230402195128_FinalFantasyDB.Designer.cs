﻿// <auto-generated />
using FinalFantasy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalFantasy.Migrations
{
    [DbContext(typeof(FinalFantasyDbContext))]
    [Migration("20230402195128_FinalFantasyDB")]
    partial class FinalFantasyDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalFantasy.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 7,
                            Name = "Cloud Strife"
                        },
                        new
                        {
                            Id = 2,
                            GameId = 7,
                            Name = "Tifa Lockhart"
                        },
                        new
                        {
                            Id = 3,
                            GameId = 8,
                            Name = "Squall Leonhart"
                        },
                        new
                        {
                            Id = 4,
                            GameId = 8,
                            Name = "Riona Heartilly"
                        },
                        new
                        {
                            Id = 5,
                            GameId = 9,
                            Name = "Zidane Tribal"
                        },
                        new
                        {
                            Id = 6,
                            GameId = 9,
                            Name = "Garnet Til Alexandros XVII"
                        });
                });

            modelBuilder.Entity("FinalFantasy.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Final Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Final Fantasy II"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Final Fantasy III"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Final Fantasy IV"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Final Fantasy V"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Final Fantasy VI"
                        },
                        new
                        {
                            Id = 7,
                            Title = "Final Fantasy VII"
                        },
                        new
                        {
                            Id = 8,
                            Title = "Final Fantasy VIII"
                        },
                        new
                        {
                            Id = 9,
                            Title = "Final Fantasy IX"
                        });
                });

            modelBuilder.Entity("FinalFantasy.Models.Character", b =>
                {
                    b.HasOne("FinalFantasy.Models.Game", "Game")
                        .WithMany("Characters")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("FinalFantasy.Models.Game", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}