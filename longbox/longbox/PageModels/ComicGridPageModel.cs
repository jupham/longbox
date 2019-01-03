using longbox.Models;
using longbox.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace longbox.PageModels
{
    class ComicGridPageModel : FreshMvvm.FreshBasePageModel
    {
        public List<Comic> ComicList { get; set; }
        IComicProvider _comicProvider;
        IComicDatabaseProvider _dbProvider;

        public ComicGridPageModel(IComicProvider comicProvider, IComicDatabaseProvider dbProvider)
        {
            _comicProvider = comicProvider;
            _dbProvider = dbProvider;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);

            ComicList = await _comicProvider.GetComicsAsync();

            await _dbProvider.WriteComicsAsync(ComicList);
            var dbComicList = await _dbProvider.GetComicsAsync();
            Debug.WriteLine(dbComicList);
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
