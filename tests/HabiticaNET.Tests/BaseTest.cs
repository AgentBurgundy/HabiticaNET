using HabiticaNET.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Tests
{
    [TestFixture]
    public class BaseTest
    {
        public string TestUsername;
        public string TestPassword;
        public string TestEmail;

        [SetUp]
        public void SetUp()
        {
            if (TestPassword == null || TestUsername == null || TestEmail == null)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"../../../../TestCredentials.txt");

                for (int i = 0; i <= 2; i++)
                {
                    if (i == 0)
                        TestUsername = file.ReadLine();
                    else if (i == 1)
                        TestPassword = file.ReadLine();
                    else
                        TestEmail = file.ReadLine();
                }
            }

            HttpResponseMessage response = Habitica.Login(TestUsername, TestPassword);

            Assert.That(response.IsSuccessStatusCode);
        }
    }
}
