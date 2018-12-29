using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace longbox.Services
{
    public interface IComicProvider
    {
        Task<String> RegisterAsync(string username, string password);

    }
}
