using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace longbox.Services
{
    public class Comixed : IComicProvider
    {
        private static Comixed _instance;
        private RestClient client;
        private string token;

        public Comixed()
        {
            client = new RestClient("http://localhost:7171");
        }

        public async Task<string> RegisterAsync(string username, string password)
        {
            var request = new RestRequest("api/generate-token");
            request.Method = Method.POST;
            request.AddParameter("email", username);
            request.AddParameter("password", password);

            var result = await client.ExecuteTaskAsync(request);
            return result.Content;
        }
    }
}
