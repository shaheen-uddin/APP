using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppProject.Models;
using Microsoft.AspNetCore.Identity;

namespace AppProject
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AdminController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInUser)
        {
            _userManager = userManager;
            _signInManager = signInUser;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Email,Password")] AdminUserModel adminUser)
        { 
            if(!ModelState.IsValid)
                {
                    return View();
                }
            var newUser = new IdentityUser{
                UserName = adminUser.Email,
                Email = adminUser.Email
            };
            var result = await _userManager.CreateAsync(newUser,adminUser.Password);
            if(!result.Succeeded)
            {
                foreach(var error in result.Errors.Select(e => e.Description))
                {
                    ModelState.AddModelError("",error);
                }
                return View();
            }

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel user, string returnUrl=null)
        {
            if(!ModelState.IsValid)
              {
                  return View();
              }

            var result = await _signInManager.PasswordSignInAsync(user.Email,user.Password,user.RememberMe,false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("","Error to sign in");
                return View();
            }
             if(String.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Create","Trainee");
            }
            else
            {
                return Redirect(returnUrl);
            }
        }
        [HttpPost]
        public IActionResult Logout(string returnUrl=null)
        {
            _signInManager.SignOutAsync();
            if(string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Create","Trainee");
            }
            return Redirect(returnUrl);
        }
    }
}