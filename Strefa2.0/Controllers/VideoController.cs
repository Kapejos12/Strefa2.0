using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace Strefa2._0.Controllers
{
    public class VideoController : Controller
    {

        string execute(string query)
        {
            string url = "http://www.omdbapi.com/?apikey=5cb2a2c4&s=" + query;

            return new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        // GET: Video
        public ActionResult Index()
        {
            string result = execute("Iron Man 3");
            ViewBag.Result = result;
            
            return View();
        }
    }
}