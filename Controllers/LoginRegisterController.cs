using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Ecommerce.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ecommerce.Controllers;

public class LoginRegisterController : Controller
{
    private readonly IUserRepository _userRepository;
    public LoginRegisterController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    

    public IActionResult Login()
    {
        if(User.Identity!.IsAuthenticated)
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
            //var isUser = _userRepository.Users.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            var isUser = _userRepository.Users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();

            if (isUser != null)
            {
                var userClaims = new List<Claim>();

                userClaims.Add(new Claim(ClaimTypes.NameIdentifier, isUser.UserId.ToString()));
                userClaims.Add(new Claim(ClaimTypes.Name, isUser.Name ?? ""));
                userClaims.Add(new Claim(ClaimTypes.GivenName, isUser.FullName ?? ""));
                userClaims.Add(new Claim(ClaimTypes.UserData, isUser.UserImage ?? ""));

                if (isUser.Email == "info@safacanbas.com")
                {
                    userClaims.Add(new Claim(ClaimTypes.Role, "admin"));
                }

                var claimsIdentity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties
                 );
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış!!!");
            }
        }

        else
        {
            ModelState.AddModelError("", "Şifre en az 6 karakter içermelidir!!!");
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
            var user = await _userRepository.Users.FirstOrDefaultAsync(x =>  x.Email == model.Email || x.Name == model.Name);
            if (user == null)
            {
                _userRepository.CreateUser(new Entity.User
                { 
                    Name = model.Name,
                    FullName = model.FullName,
                    Email = model.Email,
                    Password = model.Password,
                    UserImage = "bosAvatar.png"
                });
                return RedirectToAction("Login");

            }
            else
            {
                ModelState.AddModelError("", "Alınmış Email ya da Username!");
            }
        }
        return View(model);
    }




}
