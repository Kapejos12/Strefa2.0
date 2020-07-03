using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Strefa2._0.Controllers
{
    public class BooksController : Controller
    {
        string execute(string query)
        {
            string url = "http://openlibrary.org/search.json?q=" + query;

            return new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        private static dynamic Deserialize_json(string result)
        {
            return new JavaScriptSerializer().Deserialize<dynamic>(result);
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