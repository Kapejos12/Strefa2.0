using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Strefa2._0.Controllers
{
    public class BooksController : Controller
    {
        string execute(string query)
        {
            string url = "http://openlibrary.org/api/search?q=" + query;

            return new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        // GET: Books
        public ActionResult Index()
        {
            string result = execute("Harry Potter");

            ViewBag.Book = result;

            return View();
        }
    }
}