using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Xunit;

namespace Strefa2._0.Test
{
    public class VideoAPITesting
    {
        string execute(string query)
        {
            string url = "http://www.omdbapi.com/?apikey=5cb2a2c4&t=" + query;

            return new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        private static dynamic deserialize_json(string results)
        {
            return new JavaScriptSerializer().Deserialize<dynamic>(results);
        }

        [Fact]
        public void testing_json_response()
        {
            string json = execute("Iron Man 3");

            dynamic deserialized_object = deserialize_json(json);

            dynamic[] search_result = deserialized_object["Search"];

            Assert.True(search_result.Length > 1);

            //dynamic iron_man = search_result.SingleOrDefault(x => x["Title"] == "Iron Man 3");

            
        }
    }
}
