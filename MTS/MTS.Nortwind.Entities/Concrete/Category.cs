using MTS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Nortwind.Entities.Concrete
{
   public class Category:IEntity

    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
