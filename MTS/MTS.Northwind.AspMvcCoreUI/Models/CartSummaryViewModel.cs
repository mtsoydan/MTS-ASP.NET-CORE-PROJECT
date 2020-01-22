using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTS.Northwind.Entities.Concrete;

namespace MTS.Northwind.AspMvcCoreUI.Models
{
    public class CartSummaryViewModel
    {
        public Cart Cart { get; internal set; }
    }
}
