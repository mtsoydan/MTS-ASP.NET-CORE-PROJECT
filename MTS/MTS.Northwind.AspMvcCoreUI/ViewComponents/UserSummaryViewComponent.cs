using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MTS.Northwind.AspMvcCoreUI.Models;

namespace MTS.Northwind.AspMvcCoreUI.ViewComponents
{
    public class UserSummaryViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()

        {
            UserSummaryViewModel model = new UserSummaryViewModel
            {
                //HTTPCONTEXT İÇERİSİNDE USER.IDENTİTY İÇERİSİNDE NAME İÇERİĞİNE ERİŞEBİLİRİZ
                User = HttpContext.User.Identity.Name
            };
            return View(model);
        }
    }
}
