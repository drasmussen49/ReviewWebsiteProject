using Microsoft.EntityFrameworkCore;
using ReviewWebsiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReviewWebsiteProject
{
    public class ArcadeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ArcadeDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Pac-Man",
                    Description = "Yellow fruit-eating monster enjoys cherries but not ghosts",
                    Image = "/img/pacman.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Gauntlet Legends",
                    Description = "Save the realms from certain doom",
                    Image = "/img/GauntletLegends.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "DigDug",
                    Description = "Dig underground and defeat enemies in a maze",
                    Image = "/img/digdug.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Super Mario",
                    Description = "Italian plumber battles evil turtles to save the princess",
                    Image = "/img/supermariobros.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Mortal Kombat",
                    Description = "Battle to the death in this blood fighting game",
                    Image = "/img/mortalkombat.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Frogger",
                    Description = "Insane frog attempts to cross new york style traffic",
                    Image = "/img/frogger.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Time Crisis",
                    Description = "Attractive hero saves the world from evil dictator",
                    Image = "/img/timecrisis.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name = "Area 51",
                    Description = "Defeat Aliens that have escaped from Area 51",
                    Image = "/img/area51.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name = "San Francisco Rush",
                    Description = "Racing game with awesome stunt tracks",
                    Image = "/img/sanfranciscorush.jpg"
                }
                );
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    Id = 1,
                    Name = "Tom",
                    Content = "I Love this game. I feel like I can now conquer the world. But i'm still scared of ghosts.",
                    ProductId = 1,
                },
                new Review
                {
                    Id = 2,
                    Name = "Dan",
                    Content = "These pac-man are so cute!!. I wondered though if they'll ever get full.",
                    ProductId = 1,
                },
                new Review
                {
                    Id = 3,
                    Name = "Ghassan",
                    Content = "This game really brought me back to my past life as a medieval serf taking over my fiefdom! ",
                    ProductId = 2,
                },
                new Review
                {
                    Id = 4,
                    Name = "Eric",
                    Content = "Beware of this game. You will have nightmares for the next year. Play this game with caution.",
                    ProductId = 2,
                },
                new Review
                {
                    Id = 5,
                    Name = "Jen",
                    Content = "This game just makes me want to sing, \"Digdug, digidigidug, digdug, digidigidug.\"",
                    ProductId = 3,
                },
                new Review
                {
                    Id = 6,
                    Name = "Andy",
                    Content = "This game has inspired me to dig to China. I really think I can make it.",
                    ProductId = 3,
                }) ;
            base.OnModelCreating(modelBuilder);
        }
    }
}
