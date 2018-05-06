using HabiticaNET.Core;
using HabiticaNET.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Features.User
{
    public static class UserInfo
    {
        public static string GetUserInfoEndpoint = @"https://habitica.com/api/v3/user";

        public static HttpResponseMessage GetUserInfo(Client client, UserCredentials credentials)
        {
            return client.GetAsync(GetUserInfoEndpoint, credentials).Result;
        }
    }
}
