using longbox.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace longbox.Services
{
    public interface IComicDatabaseProvider
    {
        Task<bool> WriteComicsAsync(List<Comic> comics);
        Task<List<Comic>> GetComicsAsync();
    }
}
