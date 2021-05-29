using DirencNetClone.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DirencNetClone.Services
{
   public class OrderService
    {
        FirebaseClient client;
        public OrderService()
        {
            client = new FirebaseClient("https://direncnetclone-default-rtdb.firebaseio.com/");
        }
        public async Task<string> PlaceOrderAsync()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var data = cn.Table<CartItem>().ToList();
            var orderID = Guid.NewGuid().ToString();
            var uemail = Preferences.Get("UserEmail", "Guest");
            decimal toplamTutar = 0;
            foreach (var item in data)
            {
                OrderDetails od = new OrderDetails()
                {
                    OrderID = orderID,
                    OrderDetailID = Guid.NewGuid().ToString(),
                    ProductID = item.ProductID,
                    ProductName = item.ProductName,
                    Price = (decimal)item.Price,
                    Quantity = item.Quantity


                };
                //toplamTutar += item.Price * item.Quantity;
                await client.Child("OrderDetails").PostAsync(od);
            }
            await client.Child("Orders").PostAsync
                (
                new Order()
                {
                    OrderID = orderID,
                    UserEmail = uemail,
                    ToplamTutar = toplamTutar
                }
                );
            return orderID;
        }
    }
}
