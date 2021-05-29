using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DirencNetClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersView : ContentPage
    {
        public OrdersView()
        {
            InitializeComponent();
        }
        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductsView());
        }
    }
}