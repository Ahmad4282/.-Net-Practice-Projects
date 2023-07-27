using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee emp = employeeBusinessLayer.GetEmployeeDetails(id);

            //View Data
            ViewData["Employee"] = emp;
            ViewData["Header"] = "Employee Details";

            // View Bag
            ViewBag.Employee = emp;
            ViewBag.Header = "Employee Details";

            // return View(emp);


            //View Model

            //Employee Basic Details
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Dillip",
                Gender = "Male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };
            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Bhubaneswar",
                State = "Odisha",
                Country = "India",
                Pin = "755019"
            };
            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details",
            };

            // Temp Data
            // Setting data in TempData
            TempData["Name"] = "Pranaya";
            TempData["Age"] = 30;

            return View(employeeDetailsViewModel);

        }

        public ActionResult Details()
        {
            return View();
        }
    }
}