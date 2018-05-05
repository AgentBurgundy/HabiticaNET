using HabiticaNET.Core;
using HabiticaNET.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace HabiticaNET.Features.User
{
    public static class Authentication
    {
        public static string LoginEndpoint = @"https://habitica.com/api/v3/user/auth/local/login";        

        public static HttpResponseMessage Login(Client client, string username, string password, out UserCredentials credentials)
        {
            UserCredentials userCredentials = new UserCredentials();
            byte[] encodedCredentials = Encoding.ASCII.GetBytes($"{username}:{password}");

            Dictionary<string, string> content = new Dictionary<string, string>
                {
                    { "username", username },
                    { "password", password }
                };

            HttpResponseMessage response = client.PostAsync(LoginEndpoint, new FormUrlEncodedContent(content)).Result;

            JObject obj = JObject.Parse(response.Content.ReadAsStringAsync().Result);
            JToken data = null;
            obj.TryGetValue("data", out data);


            if (response.IsSuccessStatusCode)
                userCredentials = new UserCredentials
                {
                    Id = data.Value<string>("id"),
                    ApiToken = data.Value<string>("apiToken"),
                    IsNewUser = data.Value<bool>("newUser")
                };

            credentials = userCredentials;

            return response;
        }        
    }
}
