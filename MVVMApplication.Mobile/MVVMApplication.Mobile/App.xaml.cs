using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace MVVMApplication.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            var provider = new Dependencies().Load().GetServiceProvider();
            InitializeComponent();

            MainPage = provider.GetService<MainPage>();
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