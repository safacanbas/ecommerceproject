using Ecommerce.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data.Concrete.EfCore
{
    public class ProductContext : IdentityDbContext<User, Role, string>
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Comment> Comments => Set<Comment>();

    }
}