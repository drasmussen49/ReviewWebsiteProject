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
        public ViewResult Create()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CreateByProductId(int id, string pname)
        {
            ViewBag.ProductId = id;
            ViewBag.ProductName = pname;

            return View();
        }
        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("Details","Product", new { id = review.ProductId } );
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            Review model = reviewRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Review review)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            reviewRepo.Update(review);
            return RedirectToAction("Details", "Product", new { id = review.ProductId });
        }
        [HttpGet]
        public ViewResult Delete(int id)
        { 
            Review model = reviewRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Review review)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var tempId = review.ProductId;
            reviewRepo.Delete(review);
            return RedirectToAction("Details", "Product", new { id = tempId});
        }
    }

}

