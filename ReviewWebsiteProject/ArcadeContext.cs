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
                Content = "Tasty",
                ProductId = 1,
                },
                new Review
                {
                Id = 2,
                Content = "Not Tasty",
                ProductId = 2,
                },
                new Review
                {
                Id = 3,
                Content = "Tastiest",
                ProductId = 1,
                });
        }
    }
}
