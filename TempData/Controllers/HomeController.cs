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
            TempData["action1"] = "action1";
            return RedirectToAction("About");
        }
        public ActionResult About()
        {
            return Content("Index", TempData["action1"]);
        }
    }
}