using MTS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Northwind.Entities.Concrete
{
  public  class Category :Ientity
    {
        public int  CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}
