using System;
using System.Net.Http;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strefa2._0.Tests.Controllers
{
    [TestClass]
    public class BookAPITest
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

        [TestMethod]
        public void BookAPIResponseTest()
        {
            string result = execute("Harry Potter");

            Assert.IsNotNull(result);
        }
    }
}
