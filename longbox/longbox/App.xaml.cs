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

            MainPage = new AppShell();

            //var ComicGrid = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ComicGridPageModel>();

            //var tabbedNav = new FreshMvvm.FreshTabbedNavigationContainer();
            //tabbedNav.AddTab<ComicGridPageModel>("Comics", null);
            //MainPage = tabbedNav;
        }

        public static void Initialize()
        {
            var cp = new ComixedService();
            cp.SetProviderCredentials("comixedadmin@localhost", "comixedadmin");
            FreshMvvm.FreshIOC.Container.Register<IComicProvider>(cp);

            var db = new LongboxDatabase();
            FreshMvvm.FreshIOC.Container.Register<IComicDatabaseProvider>(db);
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
