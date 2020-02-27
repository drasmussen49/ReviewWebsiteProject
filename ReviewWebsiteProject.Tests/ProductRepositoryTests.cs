using ReviewWebsiteProject.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewWebsiteProject.Tests
{
    public class ProductRepositoryTests
    {
        private ArcadeContext db;
        private ProductRepository underTest;

        public ProductRepositoryTests()
        {
            db = new ArcadeContext();
            db.Database.BeginTransaction();
            underTest = new ProductRepository(db);
        }
        
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var db = new ArcadeContext();
            var underTest = new ProductRepository(db);

            var count = underTest.Count();

            Assert.Equal(underTest.Count(), count);
        }
    }
}
