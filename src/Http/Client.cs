using HabiticaNET.Core;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HabiticaNET.Http
{
    public class Client : HttpClient
    {
        public Client(HttpClientHandler handler) : base(handler)
        { }        

        public async Task<HttpResponseMessage> GetAsync(string endpoint, UserCredentials credentials)
        {
            if (endpoint == null)
                throw new ArgumentNullException(nameof(endpoint));

            DefaultRequestHeaders.Add("x-api-user", credentials.Id);
            DefaultRequestHeaders.Add("x-api-key", credentials.ApiToken);

            HttpResponseMessage response = await GetAsync(endpoint);
            return response;
        }

        public async Task<HttpResponseMessage> PostAsync(string endpoint, UserCredentials credentials, Dictionary<string, string> content)
        {
            if (endpoint == null)
                throw new ArgumentNullException(nameof(endpoint));

            DefaultRequestHeaders.Add("x-api-user", credentials.Id);
            DefaultRequestHeaders.Add("x-api-key", credentials.ApiToken);

            FormUrlEncodedContent data = new FormUrlEncodedContent(content);

            HttpResponseMessage response = await PostAsync(endpoint, data);

            return response;
        }
    }
}
