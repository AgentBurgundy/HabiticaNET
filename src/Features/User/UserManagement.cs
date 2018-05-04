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

        public static HttpResponseMessage ResetUser(Client client)
        {
            Dictionary<string, string> content = new Dictionary<string, string>();

            return client.PostAsync(ResetUserEndpoint, new FormUrlEncodedContent(content)).Result;
        }

        public static HttpResponseMessage ResetPassword(Client client, string email)
        {
            Dictionary<string, string> content = new Dictionary<string, string>
                {
                    { "email", email }
                };

            return client.PostAsync(ResetPasswordEndpoint, new FormUrlEncodedContent(content)).Result;
        }
    }
}
