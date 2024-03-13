using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Ecommerce.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity;
using Ecommerce.Entity;

namespace Ecommerce.Controllers;

public class LoginRegisterController : Controller
{
    private UserManager<User> _userManager;
    private SignInManager<User> _signInManager;
    public LoginRegisterController(UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }



    public IActionResult Login()
    {
        if (User.Identity!.IsAuthenticated)
        {
            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Login", "LoginRegister");
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var isUser = await _userManager.FindByEmailAsync(model.Email);

            if (isUser != null)
            {
                //await _signInManager.SignOutAsync();
                //if(!await _userManager.IsEmailConfirmedAsync(isUser))
                //{
                //    ModelState.AddModelError("", "Hesabınızı Onaylamanız Gerekmektedir.");
                //    return View(model);
                //}

                var result = await _signInManager.PasswordSignInAsync(isUser, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    await _userManager.ResetAccessFailedCountAsync(isUser);
                    await _userManager.SetLockoutEndDateAsync(isUser,null);

                    return RedirectToAction("Login", "LoginRegister");
                }
                else if (result.IsLockedOut)
                {
                    var lockoutDate = await _userManager.GetLockoutEndDateAsync(isUser);
                    var timeLeft = lockoutDate.Value - DateTime.Now;
                    ModelState.AddModelError("", $"Hesabınız Kilitlendi. Lütfen {timeLeft.Minutes} dakika sonra tekrar deneyiniz.");
                }
                else
                {
                    ModelState.AddModelError("", "Parolanız Hatalı!");
                }
            }
            else
            {
                ModelState.AddModelError("", "Bu Email adresiyle ilişkili hesap bulunamadı!"); 
            }
        }
        return View(model);
    }

    public IActionResult Register()
    {
        if (User.Identity!.IsAuthenticated)
        {
            return RedirectToAction("Login", "LoginRegister");
        }
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new User { UserName = model.UserName, Email = model.Email, FullName = model.FullName };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "LoginRegister");
            }

            foreach (IdentityError err in result.Errors)
            {
                ModelState.AddModelError("",err.Description);
            }

        }
        return View(model);
    }



}
