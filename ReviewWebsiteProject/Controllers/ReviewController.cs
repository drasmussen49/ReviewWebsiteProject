using Microsoft.AspNetCore.Mvc;
using ReviewWebsiteProject.Models;
using ReviewWebsiteProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewWebsiteProject.Controllers
{

    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;
        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);

            return View(model);
        }
        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Index","Product");
        }
    }

}

