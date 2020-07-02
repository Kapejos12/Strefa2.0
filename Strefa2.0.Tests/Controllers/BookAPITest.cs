﻿using System;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strefa2._0.Tests.Controllers
{
    [TestClass]
    public class BookAPITest
    {
        string execute(string query)
        {
            string url = "http://openlibrary.org/api/search?q=" + query;

            return new HttpClient().GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        }

        [TestMethod]
        public void BookAPIResponseTest()
        {
            string result = execute("Harry Potter");

            Assert.IsNotNull(result);
        }
    }
}
