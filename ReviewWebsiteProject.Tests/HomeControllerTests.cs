using System;
using Xunit;
using ReviewWebsiteProject.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ReviewWebsiteProject.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.Equal("Hello World", result);
        }
    }
}
