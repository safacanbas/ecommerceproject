using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ecommerce.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}