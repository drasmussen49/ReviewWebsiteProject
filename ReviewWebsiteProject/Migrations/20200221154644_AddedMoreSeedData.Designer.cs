﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewWebsiteProject;

namespace ReviewWebsiteProject.Migrations
{
    [DbContext(typeof(ArcadeContext))]
    [Migration("20200221154644_AddedMoreSeedData")]
    partial class AddedMoreSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewWebsiteProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Yellow fruit-eating monster",
                            Image = "/img/pacman.jpg",
                            Name = "Pac-Man"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Save the Realms from certain doom",
                            Image = "/img/GauntletLegends.jpg",
                            Name = "Gauntlet Legends"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dig and dug",
                            Image = "/img/digdug.jpg",
                            Name = "DigDug"
                        });
                });

            modelBuilder.Entity("ReviewWebsiteProject.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "I Love this game. I feel like I can now conquer the world. But i'm still scared of ghosts.",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "These pac-man are so cute!!. I wondered though if they'll ever get full.",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "This game really brought me back to my past life as a medieval serf taking over my fiefdom! ",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            Content = "Beware of this game. You will have nightmares for the next year. Play this game with caution.",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "This game just makes me want to sing, \"Digdug, digidigidug, digdug, digidigidug.\"",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            Content = "This game has inspired me to dig to China. I really think I can make it.",
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("ReviewWebsiteProject.Models.Review", b =>
                {
                    b.HasOne("ReviewWebsiteProject.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
