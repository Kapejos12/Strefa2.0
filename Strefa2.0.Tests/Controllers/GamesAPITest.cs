using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Strefa2._0.Tests.Controllers
{
    [TestClass]
    public class GamesAPITest
    {
        [TestMethod]
        public void response_games_api()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api-v3.igdb.com");
            request.Headers.Add("user-key", "829aa9762cd8f85ed25253962d4845f0");
            request.Headers.Add("Accept", "application/json");

            var client = new HttpClient();
            string data = client.GetAsync(request)
        }
    }
}
