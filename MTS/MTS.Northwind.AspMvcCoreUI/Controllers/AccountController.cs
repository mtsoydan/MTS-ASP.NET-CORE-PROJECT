using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MTS.Northwind.AspMvcCoreUI.Entities;
using MTS.Northwind.AspMvcCoreUI.Models;

namespace MTS.Northwind.AspMvcCoreUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _SingInManager;

        public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> SingInManager)

        {
            _userManager = userManager;
            _roleManager = roleManager;
            _SingInManager = SingInManager;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)//Eğer Model valide olarak geldiyse
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    //UserName ve Email Set ediliyor
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email
                };
                //İşlem başarılı olursa resul değeri boolean değer alır(true)
                IdentityResult result = _userManager.CreateAsync(user, registerViewModel.PassWord).Result;

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("Admin").Result)//Sistemde Admin dite bir rol varmı
                        //Default olarak admin ekliyoruz şuanda
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "Admin"
                        };
                        IdentityResult Roleresult = _roleManager.CreateAsync(role).Result;
                        if (!Roleresult.Succeeded)
                        {
                            ModelState.AddModelError("", "We cant add the role");
                            return View(registerViewModel);
                        }
                        _userManager.AddToRoleAsync(user, "Admin").Wait();
                        return RedirectToAction("Login", "Account");
                    }
                }
            }
            return View(registerViewModel);
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                //Kullanıcı adı,şifre,beni hatırla, ve hatalıysa tekrar girmek için false verdik
                var result = _SingInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.PassWord, loginViewModel.RememberMe, false).Result;
                if (result.Succeeded)
                {
                  return  RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login");
                }
            }
            return View(loginViewModel);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            _SingInManager.SignOutAsync().Wait();
            return RedirectToAction("login");

        }
    }
}