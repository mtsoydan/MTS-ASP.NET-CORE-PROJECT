using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Nortwind.Entities.Concrete
{
    class Product : IEntity
    {
        public int ProductID { get; set; }
        public string ProductionName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
    }
}
