using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers;

public class BlogController : Controller
{

    public IActionResult blog()
    {
        return View();
    }
    public IActionResult blogDetail()
    {
        return View();
    }
    

}
