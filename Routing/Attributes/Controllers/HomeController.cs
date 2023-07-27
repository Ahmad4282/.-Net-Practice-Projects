using Attributes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Attributes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Simulate fetching a list of books from a database.
            List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Sample Book 1", Author = "John Doe", PublicationYear = 2020, PublicationDate = new DateTime(2020, 1, 15) },
            new Book { Id = 2, Title = "Sample Book 2", Author = "Jane Smith", PublicationYear = 2019, PublicationDate = new DateTime(2019, 5, 20) },
            new Book { Id = 3, Title = "Sample Book 3", Author = "Robert Johnson", PublicationYear = 2021, PublicationDate = new DateTime(2021, 9, 5) }
        };

            return View(books);
        }

    }
}