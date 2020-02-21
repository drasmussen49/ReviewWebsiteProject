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
                    Description = "Yellow fruit-eating monster",
                    Image = "/img/pacman.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Gauntlet Legends",
                    Description = "Save the Realms from certain doom",
                    Image = "/img/GauntletLegends.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "DigDug",
                    Description = "Dig and dug",
                    Image = "/img/digdug.jpg"
                }

                );

            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                Id = 1,
                Content = "I Love this game. I feel like I can now conquer the world. But i'm still scared of ghosts.",
                ProductId = 1,
                },
                new Review
                {
                    Id = 2,
                    Content = "These pac-man are so cute!!. I wondered though if they'll ever get full.",
                    ProductId = 1,
                },
                new Review
                {
                    Id = 3,
                    Content = "This game really brought me back to my past life as a medieval serf taking over my fiefdom! ",
                    ProductId = 2,
                },
                new Review
                {
                Id = 4,
                Content = "Beware of this game. You will have nightmares for the next year. Play this game with caution.",
                ProductId = 2,
                },
                new Review
                {
                    Id = 5,
                    Content = "This game just makes me want to sing, \"Digdug, digidigidug, digdug, digidigidug.\"",
                    ProductId = 3,
                },
                new Review
                {
                Id = 6,
                Content = "This game has inspired me to dig to China. I really think I can make it.",
                ProductId = 3,
                });
        }
    }
}
