using System;
using System.Collections.Generic;
using System.Text;
using MTS.Core.Entities;

namespace MTS.Northwind.Entities.Concrete
{
   public class Product : Ientity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int  CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
