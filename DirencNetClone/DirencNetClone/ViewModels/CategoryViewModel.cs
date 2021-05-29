using DirencNetClone.Model;
using DirencNetClone.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DirencNetClone.Helpers;
using DirencNetClone.Views;
using System.Windows;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DirencNetClone.ViewModels
{
   public class CategoryViewModel:BaseViewModel
    {

        private   Category _SelectedCategory;
        public Category SelectedCategory
        {
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }
            get
            {
                return _SelectedCategory;
            }
        }




        public ObservableCollection<ProductItem> ProductItemsByCategory { get; set; }

       private  int _TotalProductItems;
        public int TotalProductItems
        {
            set
            {
                this._TotalProductItems = value;
                OnPropertyChanged();
            }
            get
            {
                return this._TotalProductItems;
            }
        }
    
        public CategoryViewModel( Category category)
        {
            SelectedCategory = category;
      

            ProductItemsByCategory = new ObservableCollection<ProductItem>();
         

            GetProductItems(category.CategoryID);

        }

         async void GetProductItems(int categoryID)
        {
            var data = await new ProductItemService().GetProductItemsByCategoryAsync(categoryID);

            ProductItemsByCategory.Clear();
            foreach (var item in data)
            {
                ProductItemsByCategory.Add(item);
            }
            TotalProductItems = ProductItemsByCategory.Count;
        }
        
    }
}
