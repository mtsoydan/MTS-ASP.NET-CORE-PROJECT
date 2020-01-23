using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTS.Northwind.AspMvcCoreUI.Models;
using MTS.Northwind.AspMvcCoreUI.Services;
using MTS.Northwind.Business.Abstract;
using MTS.Northwind.Entities.Concrete;

namespace MTS.Northwind.AspMvcCoreUI.Controllers
{
    public class CartController : Controller
    {

        private ICartSessionService _cartSessionService;

        private ICartService _cartService;

        private IProductService _productService;

        public CartController(IProductService productService, ICartService cartService, ICartSessionService IcartSessionService)
        {
            //Servislerimizi Dependecy İnjection yoluyla implemente ettik
            _cartSessionService = IcartSessionService;
            _productService = productService;
            _cartService = cartService;
        }



        public ActionResult AddToCart(int productID)
        {
            //Sessiona eklenecek ürünü veritabanından çektik
            //Yeni bir GetById Metodumuzu yazdık
            var productToBeAdded = _productService.GetByID(productID);


            //Şimdi sepete ulasalım

            //CartSession servisimiz var
            //Cartımızı getirdik
            var cart = _cartSessionService.GetCart();
            //Cartımıza ürün ekledik
            _cartService.AddToCart(cart, productToBeAdded);
            //tekrar session nesnemizi set ettik
            TempData.Add("messega",string.Format("Your Product {0} , was succesfuly added to the cart",productToBeAdded.ProductName.ToString()));
            _cartSessionService.SetCart(cart);
          return  RedirectToAction("Index", "product");

        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            var model = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(model);



        }
        public ActionResult Remove(int productID)
        {

            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productID);
            _cartSessionService.SetCart(cart);
            TempData.Add("messega", "your Product was succesfuly removed to the cart");

            return RedirectToAction("List");
        }

        public ActionResult Complete()
        {
            var ShippingDetail = new ShippingDetailViewModel
            {
                Details = new ShippingDetails()
            };
            return View(ShippingDetail);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("messega", string.Format("Alışveriş için Teşekkürler {0}",shippingDetails.FirstName));
            return View();
        }
    }
}