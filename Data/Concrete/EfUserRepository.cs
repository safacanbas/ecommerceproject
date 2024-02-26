using Ecommerce.Data.Abstract;
using Ecommerce.Data.Concrete.EfCore;
using Ecommerce.Entity;

namespace Ecommerce.Data.Concrete
{
    public class EfUserRepository : IUserRepository

    {
        private ProductContext _context;
        public EfUserRepository(ProductContext context)
        {
            _context = context;
        }

        public IQueryable<User> Users => _context.Users;

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
