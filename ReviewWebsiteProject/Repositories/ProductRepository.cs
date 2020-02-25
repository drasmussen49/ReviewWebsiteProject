using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewWebsiteProject.Models;

namespace ReviewWebsiteProject.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private ArcadeContext db;

        public ProductRepository(ArcadeContext db)
        {
            this.db = db;
        }

        public object Count()
        {
            return db.Products.Count();
        }

        public void Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public Product GetById(int id)
        {
            return db.Products.Single(p => p.Id == id);
        }

        public void Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
