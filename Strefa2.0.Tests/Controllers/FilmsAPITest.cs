using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strefa2._0.Controllers;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Script.Serialization;

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

        private static dynamic Deserialize_json(string result)
        {
            return new JavaScriptSerializer().Deserialize<dynamic>(result);
        }

        [TestMethod]
        public void VideoAPIResponse()
        {
            string result = execute("Iron Man 3");

            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void IronManResponse()
        {
            string json = execute("Iron Man");

            dynamic Deserialized_object = Deserialize_json(json);

            dynamic[] Search_result = Deserialized_object["Search"];

            dynamic Iron_man_3 = Search_result.SingleOrDefault(x => x["Title"] == "Iron Man 3");

            Assert.IsNotNull(Iron_man_3);
            Assert.AreEqual("Iron Man 3", Iron_man_3["Title"]);
            
        }
    }
}
