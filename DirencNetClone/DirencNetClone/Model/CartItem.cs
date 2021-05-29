using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirencNetClone.Model
{
 
    
        [Table("CartItem")]
        public class CartItem
        {
            [AutoIncrement, PrimaryKey]
            public int CartItemID { get; set; }
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
        }
    
}
