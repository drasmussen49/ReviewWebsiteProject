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
    public class ReviewControllerTests
    {
        ReviewController underTest;
        IRepository<Review> courseRepo;

        public ReviewControllerTests()
        {
            courseRepo = Substitute.For<IRepository<Review>>();
            underTest = new ReviewController(courseRepo);
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
            var expectedCourses = new List<Review>();
            courseRepo.GetAll().Returns(expectedCourses);

            var result = underTest.Index();

            Assert.Equal(expectedCourses, result.Model);
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
            var expectedCourse = new Review();
            courseRepo.GetById(1).Returns(expectedCourse);

            var result = underTest.Details(1);

            Assert.Equal(expectedCourse, result.Model);
        }
    }
}
