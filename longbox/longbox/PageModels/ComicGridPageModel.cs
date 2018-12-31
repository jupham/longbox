using longbox.Models;
using longbox.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace longbox.PageModels
{
    class ComicGridPageModel : FreshMvvm.FreshBasePageModel
    {
        public List<Comic> ComicList { get; set; }
        IComicProvider _comicProvider;

        public ComicGridPageModel(IComicProvider comicProvider)
        {
            _comicProvider = comicProvider;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);

            ComicList = await _comicProvider.GetComicsAsync();
        }

        public Comic SelectedComic
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<ComicPageModel>(value);
                RaisePropertyChanged();
            }
        }
    }
}
