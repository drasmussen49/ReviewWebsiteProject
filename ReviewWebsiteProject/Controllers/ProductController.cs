using Microsoft.AspNetCore.Mvc;
using ReviewWebsiteProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewWebsiteProject.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult ProductIndex()
        {
            ProductRepository productRepo = new ProductRepository();

            var model = productRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            ProductRepository productRepo = new ProductRepository();

            var model = productRepo.GetById(id);

            return View(model);
        }
    }
}
