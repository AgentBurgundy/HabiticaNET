using HabiticaNET.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Tests
{
    [TestFixture]
    [Category("Registration")]
    public class RegistrationTests
    {        
        [TestCase("HabiticaNET","password123","habiticanet1-test@gmail.com")]
        public void RegisterTestUser(string username, string password, string email)
        {
            username = username + new Random().Next(0, 1000).ToString();

            HttpResponseMessage response = Habitica.RegisterNewUser(username, password, email);

            Assert.That(response.IsSuccessStatusCode);
        }
    }
}
