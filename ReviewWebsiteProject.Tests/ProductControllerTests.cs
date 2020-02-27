using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewWebsiteProject.Controllers;
using ReviewWebsiteProject.Models;
using ReviewWebsiteProject.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewWebsiteProject.Tests
{
    public class ProductControllerTests
    {
        ProductController underTest;
        IRepository<Product> productRepo;

        public ProductControllerTests()
        {
            productRepo = Substitute.For<IRepository<Product>>();
            underTest = new ProductController(productRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            var expectedProducts = new List<Product>();
            productRepo.GetAll().Returns(expectedProducts);

            var result = underTest.Index();

            Assert.Equal(expectedProducts, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedProducts = new Product();
            productRepo.GetById(1).Returns(expectedProducts);

            var result = underTest.Details(1);

            Assert.Equal(expectedProducts, result.Model);
        }
    }
}
