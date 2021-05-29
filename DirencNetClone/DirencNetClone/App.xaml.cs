using DirencNetClone.Model;
using DirencNetClone.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DirencNetClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new LoginView();
         //    MainPage = new NavigationPage(new SettingsPage());
           string uemail = Preferences.Get("UserEmail", String.Empty);
            if (String.IsNullOrEmpty(uemail))
            {
                MainPage = new LoginView();
            }
            else
            {
                MainPage = new ProductsView();
            }
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
