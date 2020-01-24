using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTS.Northwind.AspMvcCoreUI.Models;
using MTS.Northwind.Business.Abstract;
using MTS.Northwind.Entities.Concrete;

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
            //admin panalinde gerekl olan ürünler listelendi
            var ProductListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };

            return View(ProductListViewModel);

        
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            _productService.Add(product);
            TempData.Add("message", "Product was add a successfully");
            return View();

        }
        public ActionResult Add()
        {
            return View();


        }
    }
}