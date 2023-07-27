using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["name"] = "ahmad";
            return RedirectToAction("About");
        }
        public ActionResult About()
        {
            if (TempData["name"]!= null)
            {
                TempData["name"].ToString();
            }
            return View();
        }
    }
}