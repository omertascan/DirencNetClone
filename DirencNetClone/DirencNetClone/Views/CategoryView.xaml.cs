using DirencNetClone.Model;
using DirencNetClone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirencNetClone.Services;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DirencNetClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryView : ContentPage
    {
        CategoryViewModel cvm;

        public CategoryView(Category category )
        {
            InitializeComponent();
            cvm = new CategoryViewModel(category);
            this.BindingContext=cvm
           
            

               ;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var bindingContext = BindingContext as CategoryViewModel;
            if (bindingContext != null) { }
                
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();



        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as ProductItem;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductsDetailsView(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;

        }
    }
}