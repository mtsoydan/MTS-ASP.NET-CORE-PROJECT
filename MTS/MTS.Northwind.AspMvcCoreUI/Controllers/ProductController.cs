using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTS.Northwind.AspMvcCoreUI.Models;
using MTS.Northwind.Business.Abstract;

namespace MTS.Northwind.AspMvcCoreUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int pageID=1)
        {
            int pageSize = 10;
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = products.Skip((pageID - 1) * 10).Take(pageSize).ToList()
            }; 
            return View(model);
        }
    }
}