using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Ecommerce.Data.Concrete.EfCore;
using Ecommerce.Entity;
using Ecommerce.Data.Abstract;

namespace Ecommerce.Controllers;

public class HomeController : Controller
{
    private readonly IProductRepository _productRepository;
    public HomeController(IProductRepository context)
    {
        _productRepository = context;
    }

    public IActionResult Index()
    {
        return View(
            new ProductViewModel
            {
                Products = _productRepository.Products.ToList()
            }
            );
    }


}
