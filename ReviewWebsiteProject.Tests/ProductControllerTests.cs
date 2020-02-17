using Microsoft.AspNetCore.Mvc;
using ReviewWebsiteProject.Controllers;
using ReviewWebsiteProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewWebsiteProject.Tests
{
    public class ProductControllerTests
    {
        ProductController controller;
        public ProductControllerTests()
        {
            controller = new ProductController();
        }

        [Fact]
        public void ProductIndex_Return_View()
        {
            var result = controller.ProductIndex();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ProductIndex_Passes_All_Product_Models_To_View()
        {
            var result = controller.ProductIndex();

            Assert.IsAssignableFrom<IEnumerable<ProductModel>>(result.Model);
        }

        [Fact]
        public void Details_Returns_View()
        {
            var result = controller.Details(1);

            Assert.IsType<ViewResult>(result);
        }
        
        [Fact]
        public void Passes_One_Product_To_View()
        {
            var result = controller.Details(1);

            Assert.IsType<ProductModel>(result.Model);
        }
            
    }
}
