using HTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static HTMLHelpers.Models.Department;
using System.Diagnostics;

namespace HTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // List of countries to populate the dropdown
            List<string> countries = new List<string>
    {
        "USA",
        "Canada",
        "United Kingdom",
        "Australia",
        "India"
    };

            // Pass the countries list to the view using ViewBag
            ViewBag.CountryList = new SelectList(countries, "USA");

            //Lets create list department for dropdownlist
            List<Department> ListDepartments = new List<Department>()
            {
                new Department() {Id = 1, Name="IT" },
                new Department() {Id = 2, Name="HR" },
                new Department() {Id = 3, Name="Payroll" },
            };
            ViewBag.Departments = ListDepartments;
            //lets create one employee
            Employee emp = new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "Pranaya",
                Gender = "Male",
                DepartmentID = 1
            };
            //Pass that employee to the view
            return View(emp);

        }
    }
}