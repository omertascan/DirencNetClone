using DirencNetClone.Model;
using DirencNetClone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DirencNetClone.ViewModels
{
    class ProductDetailsViewModel:BaseViewModel
    {
        private ProductItem _SelectedProductItem;
        public ProductItem SelectedProductItem
        {
            set
            {
                _SelectedProductItem = value;
                OnPropertyChanged();
            }
            get
            {
                return _SelectedProductItem;
            }
        }
        private int _TotalQuantity;
        public int TotalQuantity
        {
            set
            {
                _TotalQuantity = value;
                if (this._TotalQuantity < 0)
                    this._TotalQuantity = 0;
                if (this._TotalQuantity > 10)
                    this._TotalQuantity -= 1;
                OnPropertyChanged();
            }
            get
            {
                return _TotalQuantity;
            }
        }

        public Command IncrementOrderCommand { get; set; }
        public Command DecrementOrderCommand { get; set; }
        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }

        public ProductDetailsViewModel(ProductItem productItem)
        {
            SelectedProductItem = productItem;
            TotalQuantity = 0;
            IncrementOrderCommand = new Command(() => IncrementOrder());
            DecrementOrderCommand = new Command(() => DecrementOrder());
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(async () => await ViewCartAsync());
        }

        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());
        }

        private void DecrementOrder()
        {
            TotalQuantity--;
        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductID = SelectedProductItem.ProductID,
                    ProductName = SelectedProductItem.Name,
                    Price = SelectedProductItem.Price,
                    Quantity = TotalQuantity

                };
                var item = cn.Table<CartItem>().ToList().FirstOrDefault(c => c.ProductID == SelectedProductItem.ProductID);
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    item.Quantity += TotalQuantity;
                    cn.Update(item);
                }
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Cart", "Carta Eklendi", "OK");
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                cn.Close();
            }
        }

        private void IncrementOrder()
        {
            TotalQuantity++;
        }
    }
}
