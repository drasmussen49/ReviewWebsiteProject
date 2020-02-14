using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
    }
}
