using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;
using Ecommerce.Data.Concrete.EfCore;
using Ecommerce.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using Ecommerce.Entity;
using System.Security.Claims;

namespace Ecommerce.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly ICommentRepository _commentRepository;
    public ProductController(IProductRepository productRepository, ICommentRepository commentRepository)
    {
        _productRepository = productRepository;
        _commentRepository = commentRepository;
    }
    public IActionResult product()
    {
        return View(new ProductViewModel
        {
            Products = _productRepository.Products.ToList()
        });
    }
    public async Task<IActionResult> productDetail(string url)
    {
        return View(await _productRepository
            .Products
            .Include(c => c.Comments)
            .ThenInclude(u => u.User)
            .FirstOrDefaultAsync(p => p.Url == url));
    }

    [HttpPost]
    public JsonResult AddComment(int ProductId, string Text)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var userName = User.FindFirstValue(ClaimTypes.Name);
        var userImage = User.FindFirstValue(ClaimTypes.UserData);

        var entity = new Comment
        {
            Text = Text,
            PublishedOn = DateTime.Now,
            ProductId = ProductId,
            UserId = int.Parse(userId ?? ""),
        };
        _commentRepository.CreateComments(entity);
        return Json(new
        {
            userName,
            Text,
            entity.PublishedOn,
            userImage
        });
    }

}
