using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MTS.Northwind.AspMvcCoreUI.Models;
using MTS.Northwind.Business.Abstract;
using MTS.Northwind.Entities.Concrete;

namespace MTS.Northwind.AspMvcCoreUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        IProductService _productService;
        ICategoryService _categoryService;
        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
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
          return  RedirectToAction("Add");

        }
        public ActionResult Add()
        {
            
            //Ekleme modelinde categori bilgileri view a gönderiliyor
            var model = new ProductAddViewModel()
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);


        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            _productService.Update(product);
            TempData.Add("message", "Product was add a successfully");
            return RedirectToAction("Update");

        }
        public ActionResult Update(int productID)
        {

            //Ekleme modelinde categori bilgileri view a gönderiliyor
            var model = new ProductUpdateViewModel()
            {
                Product = _productService.GetByID(productID),
                Categories = _categoryService.GetAll()
            };
            return View(model);


        }
        public ActionResult Delete(int productID)
        {

            //Ekleme modelinde categori bilgileri view a gönderiliyor
            Product product = _productService.GetByID(productID);
            _productService.Delete(product);
            TempData.Add("message", "Product was succesfully deleted");
            return RedirectToAction("Index");


        }
    }
}