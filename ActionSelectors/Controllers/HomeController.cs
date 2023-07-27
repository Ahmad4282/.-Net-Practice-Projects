using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionSelectors.Controllers
{
    public class HomeController : Controller
    {
        [NonAction]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}