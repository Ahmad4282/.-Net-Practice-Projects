using AuthenticationAndAuthrization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthenticationAndAuthrization.Controllers
{
    public class HomeController : Controller
    {
        // Replace this with your actual user repository or database access logic
        private bool IsUserAuthenticated(string username, string password)
        {
            // Perform user authentication logic here
            // For demonstration purposes, we'll assume the user is authenticated if the username and password are "admin"
            return username == "admin" && password == "admin";
        }

        // GET: /User/Logout
        public ActionResult Logout()
        {
            // Sign out the user and remove the authentication cookie
            FormsAuthentication.SignOut();

            // Redirect the user to the login page
            return RedirectToAction("About", "Home");
        }

        // Dashboard
        [Authorize] // Apply the Authorize attribute to restrict access to authenticated users
        public ActionResult Index()
        {
            return View();
        }

        // GET: /User/Login
        public ActionResult About()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        // login atuntication api
        [HttpPost]
        public ActionResult About(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Perform user authentication here
                // If the user is authenticated, issue the authentication cookie
                if (IsUserAuthenticated(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            return View(model);
        }

        // sign up
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(SignupModel model)
        {
            if (ModelState.IsValid)
            {
                // Perform user authentication here
                // If the user is authenticated, use FormsAuthentication.RedirectFromLoginPage
                return RedirectToAction("About");
            }

            return View(model);
        }
        public ActionResult MyAction()
        {
            return View();
        }




    }
}
