using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ComixedService;
using ComixedService.Models;

namespace longbox.ViewModels
{
    public class ComicGridViewModel : BaseViewModel
    {
        private readonly IComicProvider _comicProvider;
        public List<string> comics;

        public ComicGridViewModel (IComicProvider cProvider)
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
