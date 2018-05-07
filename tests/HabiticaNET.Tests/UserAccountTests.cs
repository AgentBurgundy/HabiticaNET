using HabiticaNET.Core;
using NUnit.Framework;
using System;
using System.Net.Http;

namespace HabiticaNET.Tests
{
    [TestFixture]
    public class UserAccountTests : BaseTest
    {
        [Test]
        [Category("Credential-Breaking")]
        public void CanIResetPassword()
        {
            HttpResponseMessage response = Habitica.ResetPassword(TestEmail);

            Assert.That(response.IsSuccessStatusCode);
        }

        [Test]
        [Category("User-State-Change")]
        public void CanIResetUser()
        {
            HttpResponseMessage response = Habitica.ResetUser();

            Console.WriteLine(response);

            Assert.That(response.IsSuccessStatusCode);
        }

        [Test]
        [Category("Credential-Breaking")]
        public void CanIUpdatePassword()
        {
            HttpResponseMessage response = Habitica.UpdatePassword(TestPassword, "testingpassword-new1234");

            Console.WriteLine(response);

            Assert.That(response.IsSuccessStatusCode);
        }

        [Test]        
        public void CanIGetUserInfo()
        {
            HttpResponseMessage response = Habitica.GetUserInfo();

            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            Assert.That(response.IsSuccessStatusCode);
        }
    }
}
