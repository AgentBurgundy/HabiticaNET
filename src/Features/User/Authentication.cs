using HabiticaNET.Core;
using HabiticaNET.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Features.User
{
    public static class Authentication
    {
        public static string LoginEndpoint = @"https://habitica.com/api/v3/user/auth/local/login";        

        public static HttpResponseMessage Login(Client client, string username, string password)
        {
            Dictionary<string, string> content = new Dictionary<string, string>
                {
                    { "username", username },
                    { "password", password }
                };

            return client.PostAsync(LoginEndpoint, new FormUrlEncodedContent(content)).Result;
        }        
    }
}
