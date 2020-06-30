using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strefa2._0.Controllers;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strefa2._0.Tests.Controllers
{
    [TestClass]
    public class FilmsAPITest
    {
        string execute(string query)
        {
            string url = "http://www.omdbapi.com/?apikey=5cb2a2c4&s=" + query;

            return new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        [TestMethod]
        public void VideoAPIResponse()
        {
            string result = execute("Iron Man 3");

            Assert.IsNotNull(result);
        }
    }
}
