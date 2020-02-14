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
                {1, new ProductModel(1, "Pac-Man", "Yellow eating monster")},
                {2, new ProductModel(2, "Gauntlet Legends", "Killing Game with Swords")},
                {3, new ProductModel(3, "DigDug", "Dig to China till it blows up")}
            };
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return productDictionary.Values;
        }
 
    }
}
