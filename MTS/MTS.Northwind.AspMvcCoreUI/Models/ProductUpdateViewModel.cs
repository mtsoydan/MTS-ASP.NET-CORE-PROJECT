using System.Collections.Generic;
using MTS.Northwind.Entities.Concrete;

namespace MTS.Northwind.AspMvcCoreUI.Models
{
    public class ProductUpdateViewModel
    {
        public ProductUpdateViewModel()
        {
        }

        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}