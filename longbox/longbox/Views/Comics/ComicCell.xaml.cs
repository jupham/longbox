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
	public partial class ComicCell : ContentView
	{
		public ComicCell ()
		{
			InitializeComponent ();
		}
	}
}