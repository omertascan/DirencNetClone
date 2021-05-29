using System;
using System.Collections.Generic;
using System.Text;

namespace DirencNetClone.Model
{
   public class Order
    {
        public string OrderID { get; set; }
        public string UserEmail { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
