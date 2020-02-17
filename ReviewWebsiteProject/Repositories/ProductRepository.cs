using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewWebsiteProject.Models;

namespace ReviewWebsiteProject.Repositories
{
    public class ProductRepository : IRepository<ProductModel>
    {
        public Dictionary<int, ProductModel> productDictionary;

        public ProductRepository()
        {
            productDictionary = new Dictionary<int, ProductModel>()
            {
                {1, new ProductModel(1, "Pac-Man", "Yellow, fruit-eating monster", "I bought this arcade game, now I hate ghosts", "1.jpg")},
                {2, new ProductModel(2, "Gauntlet Legends", "Save the Realms from certain doom", "Wtf I love this game", "2.jpg")},
                {3, new ProductModel(3, "DigDug", "Dig and dug", "Being inflated until you explode has got to hurt!", "3.jpg")}
            };
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return productDictionary.Values;
        }

        public ProductModel GetById(int id)
        {
            return productDictionary[id];
        }
    }
}
