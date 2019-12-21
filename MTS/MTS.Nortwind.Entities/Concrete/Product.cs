using System;
using System.Collections.Generic;
using System.Text;
using MTS.Core.Entities;

namespace MTS.Nortwind.Entities.Concrete
{
  public  class Product : IEntity
    {
        public int ProductID { get; set; }
        public string ProductionName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
    }
}
