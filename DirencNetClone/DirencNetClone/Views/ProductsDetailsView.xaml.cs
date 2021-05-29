using DirencNetClone.Model;
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
    public partial class ProductsDetailsView : ContentPage
    {
        public ProductsDetailsView(ProductItem productItem)
        {
            InitializeComponent();
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }
    }
}