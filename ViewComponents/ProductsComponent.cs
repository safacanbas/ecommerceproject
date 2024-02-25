using Ecommerce.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace Ecommerce.ViewComponents
{
    public class ProductsComponent : ViewComponent
    {
        private IProductRepository _productRepository;
        public ProductsComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _productRepository.Products.ToListAsync());
        }
    }
}
