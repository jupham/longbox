using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using longbox.Views;
using Autofac;
using longbox.Services;
using longbox.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace longbox
{
    public partial class App : Application
    {
        public static Autofac.IContainer Container { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static void Initialize()
        {
            
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
