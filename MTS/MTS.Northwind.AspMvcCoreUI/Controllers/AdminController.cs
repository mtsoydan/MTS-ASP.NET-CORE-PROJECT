using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTS.Northwind.AspMvcCoreUI.Models;
using MTS.Northwind.Business.Abstract;

namespace MTS.Northwind.AspMvcCoreUI.Controllers
{
    public class AdminController : Controller
    {

        IProductService _productService;
        public AdminController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var ProductListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };

            return View(ProductListViewModel);

        
        }
    }
}