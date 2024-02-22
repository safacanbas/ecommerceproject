using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers;

public class HomeController : Controller
{

    public IActionResult index()
    {
        return View();
    }
    

}
