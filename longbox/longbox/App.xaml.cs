using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using longbox.PageModels;
using longbox.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace longbox
{
    public partial class App : Application
    {

        public App()
        {
            Initialize();
            InitializeComponent();
            var ComicGrid = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ComicGridPageModel>();

            var navContainer = new FreshMvvm.FreshNavigationContainer(ComicGrid);
            MainPage = navContainer;
        }

        public static void Initialize()
        {
            var cp = new ComixedService();
            cp.SetProviderCredentials("comixedadmin@localhost", "comixedadmin");
            FreshMvvm.FreshIOC.Container.Register<IComicProvider>(cp);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
