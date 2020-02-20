using ReviewWebsiteProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewWebsiteProject.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        private ArcadeContext db;

        public ReviewRepository(ArcadeContext db)
        {
            this.db = db;
        }

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews;
        }
        public Review GetById(int id)
        {
            return db.Reviews.Single(r => r.Id == id);
        }
    }
}
