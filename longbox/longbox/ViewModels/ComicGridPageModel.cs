using longbox.Models;
using longbox.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace longbox.ViewModels
{
    public class ComicGridPageModel : BaseViewModel
    {
        private readonly IComicProvider _comicProvider;
        public List<string> comics;

        public ComicGridPageModel (IComicProvider cProvider)
        {
            _comicProvider = cProvider;
            Title = "Comics TEST";
        }

        public async Task<List<Comic>> GetComics()
        {
            var comics = await _comicProvider.GetComicsAsync();
            return comics;
        }
    }
}
