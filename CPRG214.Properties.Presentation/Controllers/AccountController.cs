﻿using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using CPRG214.Properties.Presentation.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CPRG214.Properties.Presentation.Controllers
{
    public class AccountController : Controller
    {
        // Route:   /Account/Login
        public IActionResult Login(string returnUrl = null)
        {
            if (returnUrl != null)
                TempData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(User user)
        {
            //authenticate using the manager
            var usr = UserManager.Authenticate(user.Username, user.Password);

            if (user == null)
            {
                return View();
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, usr.Username),
                new Claim("FullName", usr.FullName),
                new Claim(ClaimTypes.Role, usr.Role)
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");

            await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimsIdentity));

            if (TempData["ReturnUrl"] == null)
                return RedirectToAction("Index", "Home");
            else
                return Redirect(TempData["ReturnUrl"].ToString());
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync("Cookies");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}