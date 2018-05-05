using HabiticaNET.Features.User;
using HabiticaNET.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Core
{
    public static class Habitica
    {
        public static UserCredentials CurrentAuthenticatedCredentials = default(UserCredentials);
        public static Client CurrentClient = new Client(new NoProxyHandler());

        public static HttpResponseMessage Login(string username, string password)
        {
            return Authentication.Login(CurrentClient, username, password, out CurrentAuthenticatedCredentials);
        }

        public static HttpResponseMessage ResetPassword(string email)
        {
            return UserManagement.ResetPassword(CurrentClient, CurrentAuthenticatedCredentials, email);
        }

        public static HttpResponseMessage ResetUser()
        {
            return UserManagement.ResetUser(CurrentClient, CurrentAuthenticatedCredentials);
        }

        public static HttpResponseMessage UpdatePassword(string oldPassword, string newPassword)
        {
            return UserManagement.UpdatePassword(CurrentClient, CurrentAuthenticatedCredentials, oldPassword, newPassword);
        }
    }
}
