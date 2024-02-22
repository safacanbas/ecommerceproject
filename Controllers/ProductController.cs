using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers;

public class ProductController : Controller
{
    
    public IActionResult product()
    {
        return View();
    }
    public IActionResult productDetail()
    {
        return View();
    }

}
