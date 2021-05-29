using DirencNetClone.Model;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirencNetClone.Services
{
   public class ProductItemService
    {
        FirebaseClient client;
        public ProductItemService()
        {
            client = new FirebaseClient("https://direncnetclone-default-rtdb.firebaseio.com/");
        }
        public async Task<List<ProductItem>> GetProductItemsAsync()
        {
            var products = (await client.Child("ProductItem").OnceAsync<ProductItem>()).Select(p => new ProductItem
            {
                CategoryID = p.Object.CategoryID,
                Name = p.Object.Name,
                ProductID = p.Object.ProductID,
                Price = p.Object.ProductID,
                ImageUrl = p.Object.ImageUrl,
                Description=p.Object.Description,
                Rating=p.Object.Rating,
                RatingDetail=p.Object.RatingDetail,
                HomeSelected=p.Object.HomeSelected,

            }).ToList();
            return products;
        }
        public async Task<ObservableCollection<ProductItem>> GetProductItemsByCategoryAsync(int categoryID)
        {
            var ProductItemsByCategory = new ObservableCollection<ProductItem>();
            var items = (await GetProductItemsAsync()).Where(p => p.CategoryID == categoryID).ToList();
            foreach (var item in items)
            {
                ProductItemsByCategory.Add(item);
            }
            return ProductItemsByCategory;
        }
        public async Task<ObservableCollection<ProductItem>> GetLatestProductItemsAsync()
        {
            var latestProductItems = new ObservableCollection<ProductItem>();
            var items = (await GetProductItemsAsync()).OrderByDescending(f => f.ProductID).Take(3);
            foreach(var item in items)
            {
                latestProductItems.Add(item);
            }
            return latestProductItems;
        }
    }
}
