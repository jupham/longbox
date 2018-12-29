using ComixedService.Models;
using longbox.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace longbox.Views.Comics
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ComicGrid : ContentPage
	{
		public ComicGrid ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var vm = BindingContext as ComicGridViewModel;
            var comics = await vm.GetComics();
            foreach(Comic comic in comics)
            {
                var comicCell = new ComicCell(comic);
                ComicLayout.Children.Add(comicCell);
            }
        }
    }
}