using ComixedService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComixedService
{
    public interface IComicProvider
    {
        void SetProviderCredentials(string username, string password);
        Task<List<Comic>> GetComicsAsync();
    }
}
