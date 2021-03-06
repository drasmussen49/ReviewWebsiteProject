﻿using ReviewWebsiteProject.Models;
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

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews;
        }
        public Review GetById(int id)
        {
            return db.Reviews.Single(r => r.Id == id);
        }
        public void Update(Review review)
        {
            db.Reviews.Update(review);
            db.SaveChanges();
        }
        public void Delete(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }
    }
}
