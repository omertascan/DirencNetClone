using DirencNetClone.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DirencNetClone.Helpers
{
    class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;

        public AddCategoryData()
        {
            client = new FirebaseClient("https://direncnetclone-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID=1,
                    CategoryName="Arduino",
                        CategoryPoster ="ic_decrease.png" ,
                    ImageUrl="ccp_down_arrow.png"

                },
                new Category()
                {
                    CategoryID=2,
                    CategoryName="Bobin",
                    CategoryPoster ="ic_decrease.png" ,
                    ImageUrl="ccp_down_arrow.png"
                },
                new Category()
                {
                    CategoryID=3 ,
                    CategoryName="Buton ve Switch",
                        CategoryPoster ="ic_decrease.png" ,
                    ImageUrl="ccp_down_arrow.png"
                },
                new Category()
                {
                    CategoryID=4,
                    CategoryName="Buzzer ve Tuş Takımı",
                        CategoryPoster ="ic_decrease.png" ,
                    ImageUrl="ccp_down_arrow.png"
                },
                new Category()
                {
                    CategoryID=5,
                    CategoryName="Direnç",
                        CategoryPoster ="ic_decrease.png" ,
                    ImageUrl="ccp_down_arrow.png"
                },


            };
        }
        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        ImageUrl = category.ImageUrl,
                        CategoryPoster=category.CategoryPoster
                    }

                        );
                }

            }
            catch(Exception ex )
            {
                await Application.Current.MainPage.DisplayAlert("Hata", ex.Message, "Ok");

            }
        }
    }
}
