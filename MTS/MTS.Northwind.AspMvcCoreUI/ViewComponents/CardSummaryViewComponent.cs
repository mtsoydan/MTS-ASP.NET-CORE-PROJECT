using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MTS.Northwind.AspMvcCoreUI.Models;
using MTS.Northwind.AspMvcCoreUI.Services;
using MTS.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTS.Northwind.AspMvcCoreUI.ViewComponents
{
    public class CardSummaryViewComponent: ViewComponent
    {
        ICartSessionService _cartSessionService;
        public CardSummaryViewComponent(ICartSessionService cartSessionService)

        {//Card Session bilgisine erişip Invoke metodu içinde cart bilgilerini model yolluyoruz
            _cartSessionService = cartSessionService;
        }
         
        public ViewViewComponentResult Invoke()
        {

            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);

        }


    }
}

