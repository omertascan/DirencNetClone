using DirencNetClone.Model;
using DirencNetClone.Services;
using DirencNetClone.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DirencNetClone.ViewModels
{
  public   class ProductsViewModel :BaseViewModel
    {
        private string _UserEMail;
        public string UserEmail
        {
            set
            {
                this._UserEMail = value;
                OnPropertyChanged();
            }
            get
            {
                return this._UserEMail;
            }

        }

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<ProductItem> LatestItems { get; set; }

        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            set
            {
                this._UserCartItemsCount = value;
                OnPropertyChanged();
            }
            get
            {
                return this._UserCartItemsCount;
            }
        }


        public Command ViewCartCommand { get; set; }
        public Command LogoutCommand
        {
            get; set;
        }

        public ProductsViewModel()
        {
            var uemail = Preferences.Get("UserEmail", String.Empty);
            if (String.IsNullOrEmpty(uemail))
                UserEmail = "Guest";
            else
                UserEmail = uemail;
            UserCartItemsCount = new CartItemService().GetUserCartCount();
            Categories = new ObservableCollection<Category>();
            LatestItems = new ObservableCollection<ProductItem>();
            GetCategories();
            GetLatestItems();
            ViewCartCommand = new Command(async () => ViewCartAsync());
            LogoutCommand = new Command(async () => await LogoutAsync());


        }

       async void GetLatestItems()
        {
            var data = await new ProductItemService().GetLatestProductItemsAsync();
            LatestItems.Clear();
            foreach(var item in data)
            {
                LatestItems.Add(item);
            }
        }

        private async Task LogoutAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new LogoutVew());
        }

        private async void GetCategories()
        {
            var data = await new CategoryDataService().GetCategoriesAsync();
            Categories.Clear();
            foreach (var item in data)
            {
                Categories.Add(item);
            }
        }

        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());
        }

    }
}
