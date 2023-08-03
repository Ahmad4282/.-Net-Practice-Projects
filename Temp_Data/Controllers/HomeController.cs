using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Temp_Data.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["action1"] = "action1mgj";
            //TempData.Keep();
            return View();
            //return RedirectToAction("About");
        }

        public ActionResult About()
        {
            TempData["action2"] = "action2";
            TempData.Keep();
            return View();
            //return RedirectToAction("Contact");
        }

        public ActionResult Contact()
        {
            TempData["action3"] = "action3";

            return View();
        }
    }
}