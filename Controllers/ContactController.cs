using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers;

public class ContactController : Controller
{

    public IActionResult contact()
    {
        return View();
    }
    

}
