using Ecommerce.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data.Concrete.EfCore
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<User> Users => Set<User>();

    }
}