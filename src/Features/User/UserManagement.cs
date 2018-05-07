using HabiticaNET.Core;
using HabiticaNET.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Features.User
{
    public static class UserManagement
    {
        public static string ResetUserEndpoint = @"https://habitica.com/api/v3/user/reset";
        public static string ResetPasswordEndpoint = @"https://habitica.com/api/v3/user/reset-password";
        public static string UpdatePasswordEndpoint = @"https://habitica.com/api/v3/user/auth/update-password";

        public static HttpResponseMessage ResetUser(Client client, UserCredentials credentials)
        {
            Dictionary<string, string> content = new Dictionary<string, string>();

            return client.PostAsync(ResetUserEndpoint, credentials, content).Result;
        }

        public static HttpResponseMessage ResetPassword(Client client, UserCredentials credentials, string email)
        {
            Dictionary<string, string> content = new Dictionary<string, string>
                {
                    { "email", email }
                };

            return client.PostAsync(ResetPasswordEndpoint, credentials, content).Result;
        }

        public static HttpResponseMessage UpdatePassword(Client client, UserCredentials credentials, string oldPassword, string newPassword)
        {
            Dictionary<string, string> content = new Dictionary<string, string>()
            {
                { "password", oldPassword },
                { "newPassword", newPassword },
                { "confirmPassword", newPassword }
            };

            return client.PostAsync(ResetUserEndpoint, credentials, content).Result;
        }
    }
}
