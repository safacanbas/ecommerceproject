using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers;

public class ShopingCardController : Controller
{

    public IActionResult shopingCard()
    {
        return View();
    }
    

}
