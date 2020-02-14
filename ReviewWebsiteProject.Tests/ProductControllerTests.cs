using Microsoft.AspNetCore.Mvc;
using ReviewWebsiteProject.Controllers;
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
    }
}
