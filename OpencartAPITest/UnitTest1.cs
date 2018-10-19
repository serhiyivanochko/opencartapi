using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using NUnit.Framework;

namespace OpencartAPITest
{
    [TestClass]
    public class OpenCartAPI
    {
        [Test]
        public void TestLogin()
        {
            var client = new RestClient(GlobalData.URL+"login");

            var request = new RestRequest(Method.POST);
            request.AddParameter("username", GlobalData.username);
            request.AddParameter("key", GlobalData.key);

            var response = client.Execute(request);

            

        }
    }
}
