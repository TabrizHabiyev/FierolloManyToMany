﻿using FiorelloBack.Models;
using FiorelloBack.ViewModels;
using FrontToBack.Models;
using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();


            AppUser user = new AppUser()
            {
                FullName = register.FullName,
                UserName = register.UserName,
                Email = register.Email,
            };

            IdentityResult identityResult = await _userManager.CreateAsync(user, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            await _signInManager.SignInAsync(user, true);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult CheckSignIn()
        {
            return Content(User.Identity.IsAuthenticated.ToString());
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();

            AppUser dbUser = await _userManager.FindByNameAsync(login.UserName);

            if (dbUser == null)
            {
                ModelState.AddModelError("", "Username or Password invalid");
                return View();
            }

            var signInResult = await _signInManager.PasswordSignInAsync(dbUser, login.Password, true, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password invalid");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}