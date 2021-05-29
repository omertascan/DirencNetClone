using DirencNetClone.Helpers;
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
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        async void ButtonCategories_Clicked(object sender, EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }

        async void ButtonProducts_Clicked(object sender, EventArgs e)
        {
            var apd = new AddProductItemData();
            await apd.AddProductItemDataAsync();

        }

        private void ButtonCart_Clicked(object sender, EventArgs e)
        {
            var cct = new CreateCartTable();
            if (cct.CreateTable())
                DisplayAlert("Succes", "Cart Table Created", "Ok");
            else
                DisplayAlert("Error", "errro", "Ok");
        }
    }
}