using DirencNetClone.Services;
using DirencNetClone.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DirencNetClone.ViewModels
{
    class LogoutViewModel:BaseViewModel
    {
        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            set
            {
                _UserCartItemsCount = value;
                OnPropertyChanged();
            }
            get
            {
                return _UserCartItemsCount;
            }
        }

        private bool _IsCartExists;
        public bool IsCartExists

        {
            set
            {
                _IsCartExists = value;
                OnPropertyChanged();
            }
            get
            {
                return _IsCartExists;
            }
        }

        public Command LogoutCommand { get; set; }
        public Command GoToCartCommand { get; set; }
        public LogoutViewModel()
        {
            UserCartItemsCount = new CartItemService().GetUserCartCount();
            IsCartExists = (UserCartItemsCount > 0) ? true : false;
            LogoutCommand = new Command(async () => await LogoutUserAsync());
            GoToCartCommand = new Command(async () => await GoToCartAsync());
        }

        private async Task GoToCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());
        }

        private async Task LogoutUserAsync()
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart();
            Preferences.Remove("UserEmail");
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView());
        }
    }
}
