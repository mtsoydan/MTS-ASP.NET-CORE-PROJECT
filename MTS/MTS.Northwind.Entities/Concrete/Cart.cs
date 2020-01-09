using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTS.Northwind.Entities.Concrete
{
   public class Cart
    {
        public List<CartLine> CartLines { get; set; }
        
        
        
        public float Total
        {

            get { return CartLines.Sum(c => c.Product.UnitPrice * c.Quantity); }
        }
    }
}
