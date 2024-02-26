using Ecommerce.Entity;

namespace Ecommerce.Data.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }

        void CreateUser(User user);

    }
}
