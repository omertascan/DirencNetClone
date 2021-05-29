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
  public  class AddProductItemData
    {
        FirebaseClient client;

        public List<ProductItem> ProductItems { get; set; }
        public AddProductItemData()
        {
            client = new FirebaseClient("https://direncnetclone-default-rtdb.firebaseio.com/");
            ProductItems = new List<ProductItem>()
            {   
                //Arduino
                new ProductItem
                {
                    CategoryID=1,
                    ProductID=1,
                    Name="Orjinal Arduino Uno R3",
                     ImageUrl="OrjinalArduinoUnoR3.jpeg",
                    Description="Arduino",
                    Rating="4.8",
                    
                    RatingDetail="(121 Ratings)",
                   
                  
                    HomeSelected="CompleteHeart.png",
                    Price=226.23,

                },
                new ProductItem
                {
                    CategoryID=1,
                    ProductID=2,
                    
                    ImageUrl="OrjinalArduinoMega2560R3.jpeg",
                    Name="Orjinal Arduino Mega 2560 R3",
                    Description="Arduino",
                    Rating="4.2",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",

                    Price=406.37,
                },
                new ProductItem
                {
                    CategoryID=1,
                    ProductID=3,
                   
                    ImageUrl="OrjinalArduinoNano.jpeg",
                    Name="Orjinal Arduino Nano",
                    Description="Arduino",
                    Rating="4.6",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",

                    Price=230.48,
                },
                new ProductItem
                {
                   CategoryID=1,
                    ProductID=4,
                   
                    ImageUrl="ArduinoMega2560R3Klon.jpeg",
                    Name="Arduino Mega 2560 R3 Klon",
                    Description="Arduino",
                    Rating="4.3",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",
                   Price=45.10,
                },
                new ProductItem
                {
                    CategoryID=1,
                    ProductID=5,
                    
                    ImageUrl="ArduinoUnoR3_Klon.jpeg",
                    Name="ArduinoUnoR3-Klon",
                    Description="Arduino",
                    Rating="4.1",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",
                   Price=77.59,
                },
                new ProductItem
                {
                     CategoryID=1,
                    ProductID=6,
                   
                    ImageUrl="ArduinoUnoR3SMDCH340Chip_Klon.jpeg",
                    Name="Arduino Uno R3 SMD CH340 Chip-Klon",
                    Description="Arduino",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",
                   Price=77.59
                },
                new ProductItem
                {
                    CategoryID=1,
                    ProductID=7,
                  
                    ImageUrl="ArduinoSensorSeti.jpeg",
                    Name="Arduino Sensör Seti",
                    Description="Arduino",
                    Rating="3.5",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",
                   Price=149.21
                },
                new ProductItem{
                    CategoryID=1,
                    ProductID=8,
                
                    ImageUrl="ArduinoUnoSuperBaslangicSeti.jpeg",
                    Name="Arduino Uno Süper Başlangıç Seti",
                    Description="Arduino",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",
                   Price=288.47},
                new ProductItem
                {
                    CategoryID=1,
                    ProductID=9,
                
                    ImageUrl="A.jpeg",
                    Name="Arduino Mega Süper Başlangıç Seti",
                    Description="Arduino",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",
                   Price=376.01
                },
                //Bobin
                new ProductItem
                {
                     CategoryID=2,
                    ProductID=1,
                   
                    ImageUrl="T1UHDirencTipBobin.jpeg",
                    Name="1UH Direnc Tip Bobin",
                    Description="Bobin",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",


                    HomeSelected="CompleteHeart.png",
                   Price=0.80

                },
               new ProductItem
               {
                    CategoryID=2,
                    ProductID=2,
                  
                    ImageUrl="1UHDirencTipBobin.jpeg",
                    Name="2.2UH Direnc Tip Bobin",
                    Description="Bobin",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.80
               },
               new ProductItem
                  {
                   CategoryID=2,
                    ProductID=3,
                   
                    ImageUrl="1UHDirencTipBobin.jpeg",
                    Name="3.3UHDirencTipBobin.jpeg",
                    Description="Bobin",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.80
                  } ,
               new ProductItem
                   {
                    CategoryID=2,
                    ProductID=4,
                    
                    ImageUrl="T47UH1AKondansatorTipiBobin.jpeg",
                    Name="4.7UH 1A Kondansatör Tipi Bobin.jpeg",
                    Description="Bobin",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=2.79
                   },
              new ProductItem
                    {
                        CategoryID=2,
                    ProductID=5,
                 
                    ImageUrl="T47UH1AKondansatorTipiBobin.jpeg",
                    Name="10UH 1A Kondansatör Tipi Bobin.jpeg",
                    Description="Bobin",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=2.19

                    },
                     new ProductItem
                     {
                        CategoryID=2,
                    ProductID=6,
                 
                    ImageUrl="T47UH1AKondansatorTipiBobin.jpeg",
                    Name="15UH 1A Kondansatör Tipi Bobin.jpeg",
                    Description="Bobin",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=2.79
                     },
                     //button
                      new ProductItem
                      {
                      CategoryID=3,
                    ProductID=1,
                 
                    ImageUrl="T6x643mmTachButton.jpeg",
                    Name="6x6 4.3mm Tach Button",
                    Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.25
                      },
                       new ProductItem
                      {
                      CategoryID=3,
                    ProductID=2,
                   
                    ImageUrl="T6x643mmTachButton.jpeg",
                    Name="6x6 5mm Tach Button",
                    Description="Bobin",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.34
                      },
                        new ProductItem
                      {
                      CategoryID=3,
                    ProductID=3,
                   
                    ImageUrl="T6x643mmTachButton.jpeg",
                    Name="6x6 5.2mm Tach Button",
                  Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.50
                      },
                         new ProductItem
                      {
                      CategoryID=3,
                    ProductID=4,
                   
                    ImageUrl="T6x643mmTachButton4Bacak.jpeg",
                    Name="6x6 4.3mm Tach Button(4Bacak)",
                    Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.30
                      },
                          new ProductItem
                      {
                      CategoryID=3,
                    ProductID=5,
                    
                    ImageUrl="T6x643mmTachButton4Bacak.jpeg",
                    Name="6x6 4.5mmTachButton(4Bacak)",
                    Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.42
                      },
                           new ProductItem
                      {
                      CategoryID=3,
                    ProductID=6,
                 
                    ImageUrl="T6x643mmTachButton4Bacak.jpeg",
                    Name="6x6 5mmTachButton(4Bacak)",
                    Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.30
                      },
             new ProductItem
                      {
                      CategoryID=3,
                    ProductID=7,
                
                    ImageUrl="K12x12YuvarlakSiyahKapak.jpeg",
                    Name="12x12 Yuvarlak Siyah Kapak",
                    Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.68
                      },
              new ProductItem
                      {
                    CategoryID=3,
                    ProductID=8,
                    
                    ImageUrl="K12x12YuvarlakBeyazKapak.jpeg",
                    Name="12x12 Yuvarlak Beyaz Kapak",
                    Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.67
                      },
               new ProductItem
                      {
                      CategoryID=3,
                    ProductID=9,
                 
                    ImageUrl="K12x12YuvarlakSariKapak.jpeg",
                    Name="12z12YuvarlakSarıKapak",
                    Description="Buton",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.67
                      },
               //Buzer
                new ProductItem
                      {
                      CategoryID=4,
                    ProductID=1,
                  
                    ImageUrl="Buzzer5v_12v12mm.jpeg",
                    Name="Buzzer 5v-12v 12mm",
                    Description="Buzzer",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=1.49
                      },
                 new ProductItem
                      {
                      CategoryID=4,
                    ProductID=2,
                    
                    ImageUrl="Buzzer_BilgisayarAnakartiUyumlu.jpeg",
                    Name="Buzzer-Bilgisayar Anakartı Uyumlu",
                     Description="Buzzer",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=1.69
                      },
                  new ProductItem
                      {
                      CategoryID=4,
                    ProductID=3,
                   
                    ImageUrl="T3_24VDevreli226mmKulakliBuzzer.jpeg",
                    Name="3-24V Devreli 22.6mm Kulaklı Buzzer",
                     Description="Buzzer",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=6.74
                      },
                  //TusTakımı
                   new ProductItem
                      {
                      CategoryID=4,
                    ProductID=4,
                 
                    ImageUrl="T33x4MembranTusTakimi.jpeg",
                    Name="3x4 Membran Tuş Takımı",
                     Description="Buzzer",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=5.97
                      },
                    new ProductItem
                      {
                      CategoryID=4,
                    ProductID=5,
                  
                    ImageUrl="T4x4MembranTusTakimi.jpeg",
                    Name="4x4 Membran TuşTakımı",
                     Description="Buzzer",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                     Price=5.97
                      },
                     new ProductItem
                      {
                      CategoryID=4,
                    ProductID=6,
               
                    ImageUrl="T4x4TelefonStiliMatrixKeypad.jpeg",
                    Name="4x4 Telefon Stili Matrix Keypad",
                     Description="Buzzer",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=34.82
                      },
               //Direnc
               new ProductItem
                      {
                      CategoryID=5,
                    ProductID=1,
                
                    ImageUrl="D02R12WDirenc.jpeg",
                    Name="0.2R 1/2W Direnc",
                     Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.06
                      },
                new ProductItem
                      {
                      CategoryID=5,
                    ProductID=2,
                
                    ImageUrl="D02R12WDirenc.jpeg",
                    Name="1.2R 1/2W Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.06
                      },
                 new ProductItem
                      {
                      CategoryID=5,
                    ProductID=3,
                 
                    ImageUrl="D02R12WDirenc.jpeg",
                    Name="68K 1/2W Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.06
                      },
                  new ProductItem
                      {
                      CategoryID=5,
                    ProductID=4,
               
                    ImageUrl="D1R18Direnc.jpeg",
                    Name="1R 1/8 Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.03
                      },
                   new ProductItem
                      {
                      CategoryID=5,
                    ProductID=5,
                   
                    ImageUrl="D1R18Direnc.jpeg",
                    Name="2R 1/8 Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.03
                      },
                    new ProductItem
                      {
                      CategoryID=5,
                    ProductID=6,
                  
                    ImageUrl="D1R18Direnc.jpeg",
                    Name="3R 1/8 Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.03
                      },
                    new ProductItem
                      {
                      CategoryID=5,
                    ProductID=7,
                   
                    ImageUrl="D82K1WDirenc.jpeg",
                    Name="82K 1W Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.13
                      },
                    new ProductItem
                      {
                      CategoryID=5,
                    ProductID=8,
                  
                    ImageUrl="D82K1WDirenc.jpeg",
                    Name="1MR 1W Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.16
                      },
                    new ProductItem
                      {
                      CategoryID=5,
                    ProductID=9,
                  
                    ImageUrl="D82K1WDirenc.jpeg",
                    Name="15K 1W Direnc",
                    Description="Direnc",
                    Rating="4.8",
                    RatingDetail="(121 Ratings)",
                    HomeSelected="CompleteHeart.png",
                   Price=0.16
                      },


            };


        }

        public async Task AddProductItemDataAsync()
        {
            try
            {
                foreach (var item in ProductItems)
                {
                    await client.Child("ProductItems").PostAsync(new ProductItem()
                    {
                        ProductID = item.ProductID,
                        CategoryID = item.CategoryID,
                        Description=item.Description,
                        Rating=item.Rating,
                        RatingDetail=item.RatingDetail,
                        HomeSelected=item.HomeSelected,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Price = item.Price
                    }
                        );


                }

            }

            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
