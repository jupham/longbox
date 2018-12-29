using ComixedService.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComixedService
{
    public class Comixed : IComicProvider
    {
        private RestClient _client;
        private string _token;
        private string _username;
        private string _password;

        public Comixed()
        {
            _token = null;
            _client = new RestClient("http://10.0.2.2:7171");
        }

        private async Task<TokenResponse> RegisterAsync(string username, string password)
        {
            var request = new RestRequest("api/token/generate-token");
            request.Method = Method.POST;
            request.AddParameter("email", username);
            request.AddParameter("password", password);

            var result = await _client.ExecuteTaskAsync<TokenResponse>(request);
            _client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", result.Data.Token));

            return result.Data;
        }

        public void SetProviderCredentials(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public async Task<List<Comic>> GetComicsAsync()
        {
            if (_token == null)
            {
                _token = (await RegisterAsync(_username, _password)).Token;
            }

            var request = new RestRequest("api/comics/since/0");
            request.AddQueryParameter("timeout", "60000");
            request.Method = Method.GET;

            var result = await _client.ExecuteTaskAsync<ComicResponse>(request);
            return result.Data.Comics;
        }
    }
}
