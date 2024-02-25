using Ecommerce.Entity;

namespace Ecommerce.Data.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void CreateProduct(Product product);
    }
}
