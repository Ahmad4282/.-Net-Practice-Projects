using DataAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // Process user registration logic (e.g., save to database).
                return RedirectToAction("Success");
            }

            return View(model);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}