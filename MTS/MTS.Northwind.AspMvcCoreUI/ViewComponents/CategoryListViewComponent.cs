using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MTS.Northwind.Business.Abstract;
using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTS.Northwind.AspMvcCoreUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new Models.CategoryListViewModel
            {
                categories = _categoryService.GetAll(),
                current_categories = Convert.ToInt32(HttpContext.Request.Query["categoryID"])
            };
            return View(model);
        }
    } 
}
