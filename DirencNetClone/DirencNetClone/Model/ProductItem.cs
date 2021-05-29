using System;
using System.Collections.Generic;
using System.Text;

namespace DirencNetClone.Model
{
  public class ProductItem
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public  string Rating { get; set;
                }
        public string Description { get; set;
        }
        public string RatingDetail { get; set; }
        public string HomeSelected { get; set; }

        public string ImageUrl { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
