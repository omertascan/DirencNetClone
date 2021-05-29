using DirencNetClone.Model;
using DirencNetClone.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DirencNetClone.ViewModels
{
  public  class CartViewModel :BaseViewModel
    {
        public ObservableCollection<UserCartItem> cartItems { get; set; }
        private double _ToplamTutar;
        public double ToplamTutar
        {
            set { _ToplamTutar = value; OnPropertyChanged(); }
            get { return _ToplamTutar; }

        }
        public Command PlaceOrdersCommand { get; set; }
        public CartViewModel()
        {
            cartItems = new ObservableCollection<UserCartItem>();
            LoadItems();
            PlaceOrdersCommand = new Command(async () => await PlaceOrderAsync());
        }

        private async Task PlaceOrderAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new OrdersView());
        }

        private void LoadItems()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var items = cn.Table<CartItem>().ToList();
            cartItems.Clear();
            foreach (var item in items)
            {
                cartItems.Add(new UserCartItem()
                {
                    CartItemID = item.CartItemID,
                    ProductID = item.ProductID,
                    ProductName = item.ProductName,
                    Price = (decimal)item.Price,
                    Quantity = item.Quantity,
                    Cost = (decimal)(item.Price * item.Quantity)
                });
                ToplamTutar += (item.Price * item.Quantity);

            }
        }
    }
}
