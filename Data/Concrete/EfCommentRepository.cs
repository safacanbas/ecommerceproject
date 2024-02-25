using Ecommerce.Data.Abstract;
using Ecommerce.Data.Concrete.EfCore;
using Ecommerce.Entity;

namespace Ecommerce.Data.Concrete
{
    public class EfCommentRepository : ICommentRepository

    {
        private ProductContext _context;
        public EfCommentRepository(ProductContext context)
        {
            _context = context;
        }

        public IQueryable<Comment> Comments => _context.Comments;

        public void CreateComments(Comment comments)
        {
            _context.Comments.Add(comments);
            _context.SaveChanges();
        }
    }
}
