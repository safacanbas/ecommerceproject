using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}