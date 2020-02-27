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
        IRepository<Review> reviewRepo;

        public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();
            underTest = new ReviewController(reviewRepo);
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
            var expectedReviews = new List<Review>();
            reviewRepo.GetAll().Returns(expectedReviews);

            var result = underTest.Index();

            Assert.Equal(expectedReviews, result.Model);
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
            var expectedReview = new Review();
            reviewRepo.GetById(1).Returns(expectedReview);

            var result = underTest.Details(1);

            Assert.Equal(expectedReview, result.Model);
        }
    }
}
