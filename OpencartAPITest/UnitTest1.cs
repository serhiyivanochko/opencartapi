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
            Logic logic = new Logic();
            logic.GetApiToken();

            

        }
    }
}
