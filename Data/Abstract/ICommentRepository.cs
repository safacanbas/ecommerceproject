using Ecommerce.Entity;

namespace Ecommerce.Data.Abstract
{
    public interface ICommentRepository
    {
        IQueryable<Comment> Comments { get; }

        void CreateComments(Comment comment);

    }
}
