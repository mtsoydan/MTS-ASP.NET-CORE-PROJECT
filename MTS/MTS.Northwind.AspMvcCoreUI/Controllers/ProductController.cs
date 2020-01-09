using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Index(int pageID=1,int categoryID=0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(categoryID);
            ProductListViewModel model = new ProductListViewModel()
            {

                Products = products.Skip((pageID - 1) * 10).Take(pageSize).ToList(),
                pageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                //Kendi tag helperımızı yazmak için gerekli propertyleri yolluyoruz
                currenCategory = categoryID,
                PageSize = pageSize,
                currentPage = pageID

            }; 
            return View(model);
        }
        //public string session()
        //{

        //    HttpContext.Session.SetString("MTS", "42");
        //}
    }
}