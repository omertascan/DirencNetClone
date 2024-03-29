﻿using DirencNetClone.Model;
using DirencNetClone.ViewModels;
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
    public partial class ProductsView : ContentPage
    {
      
        public ProductsView()
        {
            InitializeComponent();
            

        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var category = e.CurrentSelection.FirstOrDefault() as Category;
            if (category == null)
                return;
            await Navigation.PushModalAsync(new CategoryView(category));
            ((CollectionView)sender).SelectedItem = null;

        }
    }
}