using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers;

public class AboutController : Controller
{

    public IActionResult about()
    {
        return View();
    }
    

}
