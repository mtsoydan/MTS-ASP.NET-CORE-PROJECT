using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MTS.Northwind.Entities.Concrete; 

namespace MTS.Northwind.Entities.Concrete
{
   public class Cart
    {
        public List<CartLine> CartLines { get; set; }

        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        
        public decimal Total
        {

            get { return CartLines.Sum(c => c.Product.UnitPrice * c.Quantity); }
        }
    }
}
