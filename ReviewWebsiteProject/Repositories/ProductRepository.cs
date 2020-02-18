using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewWebsiteProject.Models;

namespace ReviewWebsiteProject.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public Dictionary<int, Product> productDictionary;

        public ProductRepository()
        {
            productDictionary = new Dictionary<int, Product>()
            {
                {1, new Product(1, "Pac-Man", "Yellow, fruit-eating monster", "I bought this arcade game, now I hate ghosts", "/img/GauntletLegends.jpg")},
                {2, new Product(2, "Gauntlet Legends", "Save the Realms from certain doom", "Wtf I love this game", "/img/pacman.jpg")},
                {3, new Product(3, "DigDug", "Dig and dug", "Being inflated until you explode has got to hurt!", "/img/digdug.jpg")}
            };
        }

        public IEnumerable<Product> GetAll()
        {
            return productDictionary.Values;
        }

        public Product GetById(int id)
        {
            return productDictionary[id];
        }
    }
}
