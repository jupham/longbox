using longbox.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
