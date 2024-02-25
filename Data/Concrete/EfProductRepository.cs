using Ecommerce.Data.Abstract;
using Ecommerce.Data.Concrete.EfCore;
using Ecommerce.Entity;

namespace Ecommerce.Data.Concrete
{
    public class EfProductRepository : IProductRepository
    {
        private ProductContext _context;
        public EfProductRepository(ProductContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
