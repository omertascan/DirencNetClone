using System;
using System.Collections.Generic;
using System.Text;

namespace DirencNetClone.Model
{
  public  class Cart
    {
        public string UserEmail { get; set; }
        public int CartID { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
