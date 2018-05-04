using HabiticaNET.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Tests
{
    [TestFixture]
    public class UserAccountTests : BaseTest
    {
        [Test]
        public void CanIResetPassword()
        {
            HttpResponseMessage response = Habitica.ResetPassword(TestEmail);

            Assert.That(response.IsSuccessStatusCode);
        }

        [Test]
        public void CanIResetUser()
        {
            HttpResponseMessage response = Habitica.ResetUser();

            Console.WriteLine(response);

            Assert.That(response.IsSuccessStatusCode);
        }
    }
}
