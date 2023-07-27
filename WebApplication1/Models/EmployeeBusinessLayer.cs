using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            //Here we hardcoded the data
            //later we will discuss how to retrieve
            //the data from a database
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Pranaya",
                Gender = "Male",
                City = "Mumbai",
                Salary = 1000,
                Address = "Andheri"
            };
            return employee;
        }
    }
}