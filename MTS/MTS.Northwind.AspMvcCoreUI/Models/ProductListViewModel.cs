using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTS.Northwind.Entities.Concrete;

namespace MTS.Northwind.AspMvcCoreUI.Models
{
    public class ProductListViewModel
    {
        public int PageSize { get; set; }
        public List<Product> Products { get; internal set; }
        public int currentPage { get; internal set; }
        public int currenCategory { get; internal set; }
        public int pageCount { get; internal set; }
    }
}
