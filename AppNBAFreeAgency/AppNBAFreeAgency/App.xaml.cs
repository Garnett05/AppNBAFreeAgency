using AppNBAFreeAgency.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNBAFreeAgency
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SelectPlayerPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
