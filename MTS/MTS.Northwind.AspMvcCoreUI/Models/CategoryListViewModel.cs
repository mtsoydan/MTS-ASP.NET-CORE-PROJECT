using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTS.Northwind.Entities.Concrete;

namespace MTS.Northwind.AspMvcCoreUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> categories { get; internal set; }
        public int current_categories { get; internal set; }
    }
}
